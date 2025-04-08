using MelissaData.CloudAPI;

namespace MelissaCloudAPIDotnet.MelissaCloudAPISamples
{
  public class StreetRouteSamples
  {
    public string licenseKey;

    public StreetRouteSamples(string licenseKey)
    {
      this.licenseKey = licenseKey;
    }

    /// <summary>
    /// This function uses the Street Route Cloud API object to make a GET request
    /// </summary>
    public void StreetRouteSample()
    {
      StreetRoute streetRoute = new StreetRoute(licenseKey);
      streetRoute.SetStartLatitude("33.637520");
      streetRoute.SetStartLongitude("-117.606920");
      streetRoute.SetEndLatitude("33.649870");
      streetRoute.SetEndLongitude("-117.582960");

      string response = streetRoute.Get<string>();
      StreetRouteResponse responseObject = streetRoute.Get<StreetRouteResponse>();

      Console.WriteLine(response);

      Console.WriteLine($"\nResults: {responseObject.Results}");
      Console.WriteLine($"Units: {responseObject.Units}");
      Console.WriteLine($"TransmissionResult: {responseObject.TransmissionResult}");
      Console.WriteLine($"TravelTime: {responseObject.TravelTime}");
      Console.WriteLine($"TotalDrivingDistance: {responseObject.TotalDrivingDistance}");
      Console.WriteLine($"TransmissionReference: {responseObject.TransmissionReference}");
      Console.WriteLine($"Version: {responseObject.Version}");
    }

    /// <summary>
    /// This asynchronous function uses the Street Route Cloud API object to make a GET request
    /// </summary>
    public async Task StreetRouteAsyncSample()
    {
      StreetRoute streetRoute = new StreetRoute(licenseKey);
      streetRoute.SetStartLatitude("33.637520");
      streetRoute.SetStartLongitude("-117.606920");
      streetRoute.SetEndLatitude("33.649870");
      streetRoute.SetEndLongitude("-117.582960");

      string response = await streetRoute.GetAsync<string>();
      StreetRouteResponse responseObject = await streetRoute.GetAsync<StreetRouteResponse>();

      Console.WriteLine(response);

      Console.WriteLine($"\nResults: {responseObject.Results}");
      Console.WriteLine($"Units: {responseObject.Units}");
      Console.WriteLine($"TransmissionResult: {responseObject.TransmissionResult}");
      Console.WriteLine($"TravelTime: {responseObject.TravelTime}");
      Console.WriteLine($"TotalDrivingDistance: {responseObject.TotalDrivingDistance}");
      Console.WriteLine($"TransmissionReference: {responseObject.TransmissionReference}");
      Console.WriteLine($"Version: {responseObject.Version}");
    }

    /// <summary>
    /// This function uses the Street Route Cloud API object to make a POST BATCH request
    /// This function showcases method 1 of setting and making POST requests: construct the POST body structure using the Cloud API's respective PostRequest class
    /// </summary>
    public void StreetRouteBatch1Sample()
    {
      StreetRoute streetRoute = new StreetRoute();
      streetRoute.SetPostBody(new StreetRoutePostRequest
      {
        CustomerID = licenseKey,
        Records = new List<StreetRouteRecordRequest>
        {
          new StreetRouteRecordRequest
          {
            RecordID = "1",
            StartLatitude = "33.637520",
            StartLongitude = "-117.606920",
            EndLatitude = "33.649870",
            EndLongitude = "-117.582960"
          },
          new StreetRouteRecordRequest
          {
            RecordID = "2",
            StartLatitude = "33.637520",
            StartLongitude = "-117.606920",
            EndLatitude = "33.6328945",
            EndLongitude = "-117.61098"
          }
        }
      });

      string response = streetRoute.Post<string>();
      StreetRouteResponse responseObject = streetRoute.Post<StreetRouteResponse>();

      Console.WriteLine(response);

      foreach (var record in responseObject.Records)
      {
        Console.WriteLine($"\nRecordID: {record.RecordID}");
        Console.WriteLine($"Results: {record.Results}");
        Console.WriteLine($"TravelTime: {record.TravelTime}");
        Console.WriteLine($"TotalDrivingDistance: {record.TotalDrivingDistance}");
      }
    }

    /// <summary>
    /// This function uses the Street Route Cloud API object to make a POST BATCH request
    /// This function showcases method 2 of setting and making POST requests: construct the POST body record by using the Cloud API's respective RecordRequest class
    /// </summary>
    public void StreetRouteBatch2Sample()
    {
      StreetRoute streetRoute = new StreetRoute(licenseKey);
      streetRoute.AddRecord(new StreetRouteRecordRequest
      {
        RecordID = "1",
        StartLatitude = "33.637520",
        StartLongitude = "-117.606920",
        EndLatitude = "33.649870",
        EndLongitude = "-117.582960"
      });
      streetRoute.AddRecord(new StreetRouteRecordRequest
      {
        RecordID = "2",
        StartLatitude = "33.637520",
        StartLongitude = "-117.606920",
        EndLatitude = "33.6328945",
        EndLongitude = "-117.61098"
      });

      string response = streetRoute.Post<string>();
      StreetRouteResponse responseObject = streetRoute.Post<StreetRouteResponse>();

      Console.WriteLine(response);

      foreach (var record in responseObject.Records)
      {
        Console.WriteLine($"\nRecordID: {record.RecordID}");
        Console.WriteLine($"Results: {record.Results}");
        Console.WriteLine($"TravelTime: {record.TravelTime}");
        Console.WriteLine($"TotalDrivingDistance: {record.TotalDrivingDistance}");
      }
    }

    /// <summary>
    /// This asynchronous function uses the Street Route Cloud API object to make a POST BATCH request
    /// This function showcases method 1 of setting and making POST requests: construct the POST body structure using the Cloud API's respective PostRequest class
    /// </summary>
    public async Task StreetRouteBatchAsyncSample()
    {
      StreetRoute streetRoute = new StreetRoute();
      streetRoute.SetPostBody(new StreetRoutePostRequest
      {
        CustomerID = licenseKey,
        Records = new List<StreetRouteRecordRequest>
        {
          new StreetRouteRecordRequest
          {
            RecordID = "1",
            StartLatitude = "33.637520",
            StartLongitude = "-117.606920",
            EndLatitude = "33.649870",
            EndLongitude = "-117.582960"
          },
          new StreetRouteRecordRequest
          {
            RecordID = "2",
            StartLatitude = "33.637520",
            StartLongitude = "-117.606920",
            EndLatitude = "33.6328945",
            EndLongitude = "-117.61098"
          }
        }
      });

      string response = await streetRoute.PostAsync<string>();
      StreetRouteResponse responseObject = await streetRoute.PostAsync<StreetRouteResponse>();

      Console.WriteLine(response);

      foreach (var record in responseObject.Records)
      {
        Console.WriteLine($"\nRecordID: {record.RecordID}");
        Console.WriteLine($"Results: {record.Results}");
        Console.WriteLine($"TravelTime: {record.TravelTime}");
        Console.WriteLine($"TotalDrivingDistance: {record.TotalDrivingDistance}");
      }
    }

    public void StreetRouteSetValueSample()
    {
      StreetRoute streetRoute = new StreetRoute(licenseKey);
      streetRoute.SetValue("StartLatitude", "33.637520");
      streetRoute.SetValue("StartLongitude", "-117.606920");
      streetRoute.SetValue("EndLatitude", "33.649870");
      streetRoute.SetValue("EndLongitude", "-117.582960");

      string response = streetRoute.Get<string>();
      StreetRouteResponse responseObject = streetRoute.Get<StreetRouteResponse>();

      Console.WriteLine(response);

      Console.WriteLine($"\nResults: {responseObject.Results}");
      Console.WriteLine($"Units: {responseObject.Units}");
      Console.WriteLine($"TransmissionResult: {responseObject.TransmissionResult}");
      Console.WriteLine($"TravelTime: {responseObject.TravelTime}");
      Console.WriteLine($"TotalDrivingDistance: {responseObject.TotalDrivingDistance}");
      Console.WriteLine($"TransmissionReference: {responseObject.TransmissionReference}");
      Console.WriteLine($"Version: {responseObject.Version}");
    }

    public void StreetRouteSetValueSample2()
    {
      StreetRoute streetRoute = new StreetRoute(licenseKey);
      streetRoute.StartLatitude = "33.637520";
      streetRoute.StartLongitude = "-117.606920";
      streetRoute.EndLatitude = "33.649870";
      streetRoute.EndLongitude = "-117.582960";

      string response = streetRoute.Get<string>();
      StreetRouteResponse responseObject = streetRoute.Get<StreetRouteResponse>();

      Console.WriteLine(response);

      Console.WriteLine($"\nResults: {responseObject.Results}");
      Console.WriteLine($"Units: {responseObject.Units}");
      Console.WriteLine($"TransmissionResult: {responseObject.TransmissionResult}");
      Console.WriteLine($"TravelTime: {responseObject.TravelTime}");
      Console.WriteLine($"TotalDrivingDistance: {responseObject.TotalDrivingDistance}");
      Console.WriteLine($"TransmissionReference: {responseObject.TransmissionReference}");
      Console.WriteLine($"Version: {responseObject.Version}");
    }
  }
}
