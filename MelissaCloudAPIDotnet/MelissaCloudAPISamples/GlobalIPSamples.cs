using MelissaData.CloudAPI;

namespace MelissaCloudAPIDotnet.MelissaCloudAPISamples
{
  public class GlobalIPSamples
  {
    public string licenseKey;

    public GlobalIPSamples(string licenseKey)
    {
      this.licenseKey = licenseKey;
    }

    /// <summary>
    /// This function uses the Global IP Cloud API object to make a GET request
    /// </summary>
    public void GlobalIPSample()
    {
      GlobalIP globalIP = new GlobalIP(licenseKey);
      globalIP.SetIP("12.203.219.6");

      string response = globalIP.Get<string>();
      GlobalIPResponse responseObject = globalIP.Get<GlobalIPResponse>();

      Console.WriteLine(response);

      Console.WriteLine($"\nVersion: {responseObject.Version}");
      Console.WriteLine($"TransmissionReference: {responseObject.TransmissionReference}");
      Console.WriteLine($"TransmissionResults: {responseObject.TransmissionResults}\n");
      foreach (var record in responseObject.Records)
      {
        Console.WriteLine("City: " + record.City);
        Console.WriteLine("ConnectionSpeed: " + record.ConnectionSpeed);
        Console.WriteLine("ConnectionType: " + record.ConnectionType);
        Console.WriteLine("Continent: " + record.Continent);
        Console.WriteLine("CountryAbbreviation: " + record.CountryAbbreviation);
        Console.WriteLine("CountryName: " + record.CountryName);
        Console.WriteLine("DomainName: " + record.DomainName);
        Console.WriteLine("DST: " + record.DST);
        Console.WriteLine("IPAddress: " + record.IPAddress);
        Console.WriteLine("ISPName: " + record.ISPName);
        Console.WriteLine("Latitude: " + record.Latitude);
        Console.WriteLine("Longitude: " + record.Longitude);
        Console.WriteLine("PostalCode: " + record.PostalCode);
        Console.WriteLine("ProxyDescription: " + record.ProxyDescription);
        Console.WriteLine("ProxyType: " + record.ProxyType);
        Console.WriteLine("RecordID: " + record.RecordID);
        Console.WriteLine("Region: " + record.Region);
        Console.WriteLine("Result: " + record.Result);
        Console.WriteLine("TimeZoneCode: " + record.TimeZoneCode);
        Console.WriteLine("TimeZoneName: " + record.TimeZoneName);
        Console.WriteLine("UTC: " + record.UTC + "\n\n");
      }
    }

    /// <summary>
    /// This asynchronous function uses the Global IP Cloud API object to make a GET request
    /// </summary>
    public async Task GlobalIPAsyncSample()
    {
      GlobalIP globalIP = new GlobalIP(licenseKey);
      globalIP.SetIP("12.203.219.6");

      string response = await globalIP.GetAsync<string>();
      GlobalIPResponse responseObject = await globalIP.GetAsync<GlobalIPResponse>();

      Console.WriteLine(response);

      Console.WriteLine($"\nVersion: {responseObject.Version}");
      Console.WriteLine($"TransmissionReference: {responseObject.TransmissionReference}");
      Console.WriteLine($"TransmissionResults: {responseObject.TransmissionResults}\n");
      foreach (var record in responseObject.Records)
      {
        Console.WriteLine("City: " + record.City);
        Console.WriteLine("ConnectionSpeed: " + record.ConnectionSpeed);
        Console.WriteLine("ConnectionType: " + record.ConnectionType);
        Console.WriteLine("Continent: " + record.Continent);
        Console.WriteLine("CountryAbbreviation: " + record.CountryAbbreviation);
        Console.WriteLine("CountryName: " + record.CountryName);
        Console.WriteLine("DomainName: " + record.DomainName);
        Console.WriteLine("DST: " + record.DST);
        Console.WriteLine("IPAddress: " + record.IPAddress);
        Console.WriteLine("ISPName: " + record.ISPName);
        Console.WriteLine("Latitude: " + record.Latitude);
        Console.WriteLine("Longitude: " + record.Longitude);
        Console.WriteLine("PostalCode: " + record.PostalCode);
        Console.WriteLine("ProxyDescription: " + record.ProxyDescription);
        Console.WriteLine("ProxyType: " + record.ProxyType);
        Console.WriteLine("RecordID: " + record.RecordID);
        Console.WriteLine("Region: " + record.Region);
        Console.WriteLine("Result: " + record.Result);
        Console.WriteLine("TimeZoneCode: " + record.TimeZoneCode);
        Console.WriteLine("TimeZoneName: " + record.TimeZoneName);
        Console.WriteLine("UTC: " + record.UTC + "\n\n");
      }
    }

    /// <summary>
    /// This function uses the Global IP Cloud API object to make a POST BATCH request
    /// This function showcases method 1 of setting and making POST requests: construct the POST body structure using the Cloud API's respective PostRequest class
    /// </summary>
    public void GlobalIPBatch1Sample()
    {
      GlobalIP globalIP = new GlobalIP();
      globalIP.SetPostBody(new GlobalIPPostRequest
      {
        CustomerID = licenseKey,
        Records = new List<GlobalIPRecordRequest>
        {
          new GlobalIPRecordRequest
          {
            RecordID = "1",
            IPAddress = "12.203.219.6"
          },
          new GlobalIPRecordRequest
          {
            RecordID = "2",
            IPAddress = "139.101.81.42"
          }
        }
      });

      string response = globalIP.Post<string>();
      GlobalIPResponse responseObject = globalIP.Post<GlobalIPResponse>();

      Console.WriteLine(response);

      Console.WriteLine($"\nVersion: {responseObject.Version}");
      Console.WriteLine($"TransmissionReference: {responseObject.TransmissionReference}");
      Console.WriteLine($"TransmissionResults: {responseObject.TransmissionResults}\n");
      foreach (var record in responseObject.Records)
      {
        Console.WriteLine("City: " + record.City);
        Console.WriteLine("ConnectionSpeed: " + record.ConnectionSpeed);
        Console.WriteLine("ConnectionType: " + record.ConnectionType);
        Console.WriteLine("Continent: " + record.Continent);
        Console.WriteLine("CountryAbbreviation: " + record.CountryAbbreviation);
        Console.WriteLine("CountryName: " + record.CountryName);
        Console.WriteLine("DomainName: " + record.DomainName);
        Console.WriteLine("DST: " + record.DST);
        Console.WriteLine("IPAddress: " + record.IPAddress);
        Console.WriteLine("ISPName: " + record.ISPName);
        Console.WriteLine("Latitude: " + record.Latitude);
        Console.WriteLine("Longitude: " + record.Longitude);
        Console.WriteLine("PostalCode: " + record.PostalCode);
        Console.WriteLine("ProxyDescription: " + record.ProxyDescription);
        Console.WriteLine("ProxyType: " + record.ProxyType);
        Console.WriteLine("RecordID: " + record.RecordID);
        Console.WriteLine("Region: " + record.Region);
        Console.WriteLine("Result: " + record.Result);
        Console.WriteLine("TimeZoneCode: " + record.TimeZoneCode);
        Console.WriteLine("TimeZoneName: " + record.TimeZoneName);
        Console.WriteLine("UTC: " + record.UTC + "\n\n");
      }
    }

    /// <summary>
    /// This function uses the Global IP Cloud API object to make a POST BATCH request
    /// This function showcases method 2 of setting and making POST requests: construct the POST body record by using the Cloud API's respective RecordRequest class
    /// </summary>
    public void GlobalIPBatch2Sample()
    {
      GlobalIP globalIP = new GlobalIP(licenseKey);
      globalIP.AddRecord(new GlobalIPRecordRequest
      {
        RecordID = "1",
        IPAddress = "12.203.219.6"
      });
      globalIP.AddRecord(new GlobalIPRecordRequest
      {
        RecordID = "2",
        IPAddress = "139.101.81.42"
      });

      string response = globalIP.Post<string>();
      GlobalIPResponse responseObject = globalIP.Post<GlobalIPResponse>();

      Console.WriteLine(response);

      Console.WriteLine($"\nVersion: {responseObject.Version}");
      Console.WriteLine($"TransmissionReference: {responseObject.TransmissionReference}");
      Console.WriteLine($"TransmissionResults: {responseObject.TransmissionResults}\n");
      foreach (var record in responseObject.Records)
      {
        Console.WriteLine("City: " + record.City);
        Console.WriteLine("ConnectionSpeed: " + record.ConnectionSpeed);
        Console.WriteLine("ConnectionType: " + record.ConnectionType);
        Console.WriteLine("Continent: " + record.Continent);
        Console.WriteLine("CountryAbbreviation: " + record.CountryAbbreviation);
        Console.WriteLine("CountryName: " + record.CountryName);
        Console.WriteLine("DomainName: " + record.DomainName);
        Console.WriteLine("DST: " + record.DST);
        Console.WriteLine("IPAddress: " + record.IPAddress);
        Console.WriteLine("ISPName: " + record.ISPName);
        Console.WriteLine("Latitude: " + record.Latitude);
        Console.WriteLine("Longitude: " + record.Longitude);
        Console.WriteLine("PostalCode: " + record.PostalCode);
        Console.WriteLine("ProxyDescription: " + record.ProxyDescription);
        Console.WriteLine("ProxyType: " + record.ProxyType);
        Console.WriteLine("RecordID: " + record.RecordID);
        Console.WriteLine("Region: " + record.Region);
        Console.WriteLine("Result: " + record.Result);
        Console.WriteLine("TimeZoneCode: " + record.TimeZoneCode);
        Console.WriteLine("TimeZoneName: " + record.TimeZoneName);
        Console.WriteLine("UTC: " + record.UTC + "\n\n");
      }
    }

    /// <summary>
    /// This asynchronous function uses the Global Address Verification Cloud API object to make a POST request
    /// </summary>
    public async Task GlobalIPBatchAsyncSample()
    {
      GlobalIP globalIP = new GlobalIP();
      globalIP.SetPostBody(new GlobalIPPostRequest
      {
        CustomerID = licenseKey,
        Records = new List<GlobalIPRecordRequest>
        {
          new GlobalIPRecordRequest
          {
            RecordID = "1",
            IPAddress = "12.203.219.6"
          },
          new GlobalIPRecordRequest
          {
            RecordID = "2",
            IPAddress = "139.101.81.42"
          }
        }
      });

      string response = await globalIP.PostAsync<string>();
      GlobalIPResponse responseObject = await globalIP.PostAsync<GlobalIPResponse>();

      Console.WriteLine(response);

      Console.WriteLine($"\nVersion: {responseObject.Version}");
      Console.WriteLine($"TransmissionReference: {responseObject.TransmissionReference}");
      Console.WriteLine($"TransmissionResults: {responseObject.TransmissionResults}\n");
      foreach (var record in responseObject.Records)
      {
        Console.WriteLine("City: " + record.City);
        Console.WriteLine("ConnectionSpeed: " + record.ConnectionSpeed);
        Console.WriteLine("ConnectionType: " + record.ConnectionType);
        Console.WriteLine("Continent: " + record.Continent);
        Console.WriteLine("CountryAbbreviation: " + record.CountryAbbreviation);
        Console.WriteLine("CountryName: " + record.CountryName);
        Console.WriteLine("DomainName: " + record.DomainName);
        Console.WriteLine("DST: " + record.DST);
        Console.WriteLine("IPAddress: " + record.IPAddress);
        Console.WriteLine("ISPName: " + record.ISPName);
        Console.WriteLine("Latitude: " + record.Latitude);
        Console.WriteLine("Longitude: " + record.Longitude);
        Console.WriteLine("PostalCode: " + record.PostalCode);
        Console.WriteLine("ProxyDescription: " + record.ProxyDescription);
        Console.WriteLine("ProxyType: " + record.ProxyType);
        Console.WriteLine("RecordID: " + record.RecordID);
        Console.WriteLine("Region: " + record.Region);
        Console.WriteLine("Result: " + record.Result);
        Console.WriteLine("TimeZoneCode: " + record.TimeZoneCode);
        Console.WriteLine("TimeZoneName: " + record.TimeZoneName);
        Console.WriteLine("UTC: " + record.UTC + "\n\n");
      }
    }

    public void GlobalIPSetValueSample()
    {
      GlobalIP globalIP = new GlobalIP(licenseKey);
      globalIP.SetValue("IP", "12.203.219.6");

      string response = globalIP.Get<string>();
      GlobalIPResponse responseObject = globalIP.Get<GlobalIPResponse>();

      Console.WriteLine(response);

      Console.WriteLine($"\nVersion: {responseObject.Version}");
      Console.WriteLine($"TransmissionReference: {responseObject.TransmissionReference}");
      Console.WriteLine($"TransmissionResults: {responseObject.TransmissionResults}\n");
      foreach (var record in responseObject.Records)
      {
        Console.WriteLine("City: " + record.City);
        Console.WriteLine("ConnectionSpeed: " + record.ConnectionSpeed);
        Console.WriteLine("ConnectionType: " + record.ConnectionType);
        Console.WriteLine("Continent: " + record.Continent);
        Console.WriteLine("CountryAbbreviation: " + record.CountryAbbreviation);
        Console.WriteLine("CountryName: " + record.CountryName);
        Console.WriteLine("DomainName: " + record.DomainName);
        Console.WriteLine("DST: " + record.DST);
        Console.WriteLine("IPAddress: " + record.IPAddress);
        Console.WriteLine("ISPName: " + record.ISPName);
        Console.WriteLine("Latitude: " + record.Latitude);
        Console.WriteLine("Longitude: " + record.Longitude);
        Console.WriteLine("PostalCode: " + record.PostalCode);
        Console.WriteLine("ProxyDescription: " + record.ProxyDescription);
        Console.WriteLine("ProxyType: " + record.ProxyType);
        Console.WriteLine("RecordID: " + record.RecordID);
        Console.WriteLine("Region: " + record.Region);
        Console.WriteLine("Result: " + record.Result);
        Console.WriteLine("TimeZoneCode: " + record.TimeZoneCode);
        Console.WriteLine("TimeZoneName: " + record.TimeZoneName);
        Console.WriteLine("UTC: " + record.UTC + "\n\n");
      }
    }

    public void GlobalIPSetValueSample2()
    {
      GlobalIP globalIP = new GlobalIP(licenseKey);
      globalIP.IP = "12.203.219.6";

      string response = globalIP.Get<string>();
      GlobalIPResponse responseObject = globalIP.Get<GlobalIPResponse>();

      Console.WriteLine(response);

      Console.WriteLine($"\nVersion: {responseObject.Version}");
      Console.WriteLine($"TransmissionReference: {responseObject.TransmissionReference}");
      Console.WriteLine($"TransmissionResults: {responseObject.TransmissionResults}\n");
      foreach (var record in responseObject.Records)
      {
        Console.WriteLine("City: " + record.City);
        Console.WriteLine("ConnectionSpeed: " + record.ConnectionSpeed);
        Console.WriteLine("ConnectionType: " + record.ConnectionType);
        Console.WriteLine("Continent: " + record.Continent);
        Console.WriteLine("CountryAbbreviation: " + record.CountryAbbreviation);
        Console.WriteLine("CountryName: " + record.CountryName);
        Console.WriteLine("DomainName: " + record.DomainName);
        Console.WriteLine("DST: " + record.DST);
        Console.WriteLine("IPAddress: " + record.IPAddress);
        Console.WriteLine("ISPName: " + record.ISPName);
        Console.WriteLine("Latitude: " + record.Latitude);
        Console.WriteLine("Longitude: " + record.Longitude);
        Console.WriteLine("PostalCode: " + record.PostalCode);
        Console.WriteLine("ProxyDescription: " + record.ProxyDescription);
        Console.WriteLine("ProxyType: " + record.ProxyType);
        Console.WriteLine("RecordID: " + record.RecordID);
        Console.WriteLine("Region: " + record.Region);
        Console.WriteLine("Result: " + record.Result);
        Console.WriteLine("TimeZoneCode: " + record.TimeZoneCode);
        Console.WriteLine("TimeZoneName: " + record.TimeZoneName);
        Console.WriteLine("UTC: " + record.UTC + "\n\n");
      }
    }
  }
}
