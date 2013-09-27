/*
 * Author: Edan Cain, ESRI, 380 New York Street, Redlands, California, 92373, USA. Email: ecain@esri.com Tel: 1-909-793-2853
 * 
 * Code demonstrates how to structure REST calls for interaction with ArcGIS.com organization accounts.
 * Calls are made via HttpWebRequests based on string descriptors. Both GET and POST calls are within this code 
 * and response format is JSON.
 * 
 * HttpWebResponses are dynamically binded too via the DataContract objects found within the project.
 * 
 * Code is not supported by ESRI inc, there are no use restrictions, you are free to distribute, modify and use this code.
 * Enhancement or functional code requests should be sent to Edan Cain, ecain@esri.com. 
 * 
 * Code demonstrates REST calls and parsing of the resulting response JSON for:
 * Authentication
 * Geocoding
 * Batch Geocoding
 * Reverse Geocoding
 * Routing
 * Also demonstrates how to get the service endpoints for routing and geocoding.
 * 
 * Code created to help support the Start-up community by the ESRI Emerging Business Team. If you are a start up company,
 * please contact Myles Sutherland at msutherland@esri.com.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace ArcGISOnlineRouting
{
  public partial class Form1 : Form
  {
    string _token = string.Empty;
    enum requestType
    {
      authenticate,
      geocode,
      reverseGeocode,
      batchGeocode,
      route
    };

    //of interest links
    //http://geocode.arcgis.com/arcgis/rest/services/World/GeocodeServer?f=pjson
    //http://route.arcgis.com/arcgis/rest/info?f=pjson

    public Form1()
    {
      InitializeComponent();
    }

    private string HttpGetWebRequest(string url)
    {
      HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
      httpWebRequest.Method = "GET";

      HttpWebResponse httpResponse = null;
      try
      {
        httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
      }
      catch { return null; }

      string JSON = string.Empty;

      using (StreamReader reader = new StreamReader(httpResponse.GetResponseStream()))
        JSON = reader.ReadToEnd();

      return JSON;
    }

    private string HttpPostWebRequest(string url, string transmissionContent, string referer)
    {
      HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);

      //stipulate that this request is a POST
      httpWebRequest.Method = "POST";
      httpWebRequest.Referer = referer;
      
      //convert the data to send into a byte array.
      byte[] bytesToSend = Encoding.UTF8.GetBytes(transmissionContent);

      //we need to declare the content length next
      httpWebRequest.ContentLength = bytesToSend.Length;

      //set the content type property 
      httpWebRequest.ContentType = "application/x-www-form-urlencoded";

      //get the request stream
      Stream dataStream = httpWebRequest.GetRequestStream();

      //write the data to the request stream
      dataStream.Write(bytesToSend, 0, bytesToSend.Length);

      //close it as we have no further use of it.
      dataStream.Close();

      //make the request to the server
      HttpWebResponse httpResponse = null;
      try
      {
        httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
      }
      catch { return null; }

      string JSON = string.Empty;

      using (StreamReader reader = new StreamReader(httpResponse.GetResponseStream()))
        JSON = reader.ReadToEnd();

      return JSON;
    }

    private void btnAuthenticate_Click(object sender, EventArgs e)
    {
      string url = "https://www.arcgis.com/sharing/generatetoken?f=json";
      string jsonTransmission = "username=" + txtUserName.Text + "&password=" + txtPassword.Text + "&expiration=120&referer=" + txtOrg.Text + "&f=pjson";
      //create a request using the url that can recieve a POST
      string json = string.Empty;
      try
      {
        json = HttpPostWebRequest(url, jsonTransmission, txtOrg.Text);
      }
      catch { textBox2.Text = "Invalid User Name or Password."; return; }

      if (json.Contains("error"))
      {
        textBox2.Text = "Invalid User Name or Password."; return;
      }

      Deserialize(requestType.authenticate, json);

      textBox2.Text = _token;
      EnableControls(true);
    }

    private void EnableControls(bool b)
    {
      btnBatchGeocode.Enabled = b;
      btnGeocode.Enabled = b;
      btnGeocodeService.Enabled = b;
      btnReverseGeocode.Enabled = b;
      btnRoute.Enabled = b;
      btnRouteService.Enabled = b;
    }

    private void btnGeocode_Click(object sender, EventArgs e)
    {
      string url = "http://geocode.arcgis.com/arcgis/rest/services/World/GeocodeServer/find?text=";
      if (chkbxPOI.Checked)
      {
        url += txtAddress.Text.Replace(" ", "+");
        url += "&outFields=type,city,region&maxLocations=" + txtMaxRecords.Text + "&f=pjson";
      }
      else
      {
        url += txtAddress.Text.Replace(" ", "+");
        url = url.Replace(",", "%26") + "&f=pjson";
      }

      string json = HttpGetWebRequest(url);
      Deserialize(requestType.geocode, json);

      //write the response json to the UI
      json.Replace("{", "{ \r\n");
      json.Replace(",", ", \r\n");
      json.Replace("}", "} \r\n");
      txtGeocodeResult.Text = json.Replace("{", "{\r\n");
    }

    private void btnReverseGeocode_Click(object sender, EventArgs e)
    {
      string[] ss = txtReverseGeocode.Text.Split(',');
      string url = "http://geocode.arcgis.com/arcgis/rest/services/World/GeocodeServer/reverseGeocode?location=" + ss[1] + "%2C+" + ss[0] + "&distance=200&outSR=&f=pjson";
      string json = HttpGetWebRequest(url);
      Deserialize(requestType.reverseGeocode, json);
      txtReverseGeocodeResult.Text = json;
    }

    private void btnBatchGeocode_Click(object sender, EventArgs e)
    {
      string [] split = txtBatchGeo1.Text.Split(',');
      string content = "addresses={\"records\":[";
      content += "{\"attributes\":{\"OBJECTID\":1,\"Address\":\"" + split[0] + "\",\"Neighborhood\":\"\",\"City\":\"" + split[1] + "\",\"Subregion\":\"\",\"Region\":\"" + split[2] + "\"}},";
      split = txtBatchGeo2.Text.Split(',');
      content += "{\"attributes\":{\"OBJECTID\":2,\"Address\":\"" + split[0] + "\",\"Neighborhood\":\"\",\"City\":\"" + split[1] + "\",\"Subregion\":\"\",\"Region\":\"" + split[2] + "\"}},";
      split = txtBatchGeo3.Text.Split(',');
      content += "{\"attributes\":{\"OBJECTID\":3,\"Address\":\"" + split[0] + "\",\"Neighborhood\":\"\",\"City\":\"" + split[1] + "\",\"Subregion\":\"\",\"Region\":\"" + split[2] + "\"}},";
      split = txtBatchGeo4.Text.Split(',');
      content += "{\"attributes\":{\"OBJECTID\":4,\"Address\":\"" + split[0] + "\",\"Neighborhood\":\"\",\"City\":\"" + split[1] + "\",\"Subregion\":\"\",\"Region\":\"" + split[2] + "\"}}]}";
      content += "&token=" + _token + "&sourceCountry=USA&outSR=102100&f=json";

      string url = "http://geocode.arcgis.com/arcgis/rest/services/World/GeocodeServer/geocodeAddresses?";
      string json = HttpPostWebRequest(url, content, txtOrg.Text);

      Deserialize(requestType.batchGeocode, json);
      txtBatchGeoCode.Text = json;
    }

    private void btnRoute_Click(object sender, EventArgs e)
    {
      string url = "http://route.arcgis.com/arcgis/rest/services/World/Route/NAServer/Route_World/solve?f=pjson";

      string parameters = "&stops=-117.176009399%2C34.065258746%3B-117.158225979%2C34.065907721&token=" + _token;
      
      string json = HttpPostWebRequest(url, parameters, txtOrg.Text);
      txtRoute.Text = json;
      Deserialize(requestType.route, json);
    }

    private void btnGeocodeService_Click(object sender, EventArgs e)
    {
      string url = "http://geocode.arcgis.com/arcgis/rest/services/World/GeocodeServer?f=pjson";
      string json = HttpGetWebRequest(url);
      textBox1.Text = json;
    }

    private void btnRouteService_Click(object sender, EventArgs e)
    {
      string url = "http://route.arcgis.com/arcgis/rest/info?f=pjson";
      string json = HttpGetWebRequest(url);
      json = json.Replace(",", ",\r\n");
      textBox1.Text = json;
    }

    private void Deserialize(requestType type, string json)
    {
      JavaScriptSerializer javaScriptSerializer = new JavaScriptSerializer();
      if (type == requestType.authenticate)
      {
        Authentication authentication = javaScriptSerializer.Deserialize<Authentication>(json);
        _token = authentication.token;
      }
      else if (type == requestType.batchGeocode)
      {
        BatchGeocodingResponse batchGeocodingResponse = javaScriptSerializer.Deserialize<BatchGeocodingResponse>(json);
      }
      else if (type == requestType.geocode)
      {
        Geocode geocode = javaScriptSerializer.Deserialize<Geocode>(json);
      }
      else if (type == requestType.reverseGeocode)
      {
        ReverseGeocode reverseGeocode = javaScriptSerializer.Deserialize<ReverseGeocode>(json);
      }
      else if (type == requestType.route)
      {
        RouteDataContract route = javaScriptSerializer.Deserialize<RouteDataContract>(json);
      }
    }
  }
}
