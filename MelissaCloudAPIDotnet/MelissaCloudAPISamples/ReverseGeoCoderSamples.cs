using MelissaData.CloudAPI;

namespace MelissaCloudAPIDotnet.MelissaCloudAPISamples
{
  public class ReverseGeoCoderSamples
  {
    public string licenseKey;

    public ReverseGeoCoderSamples(string licenseKey)
    {
      this.licenseKey = licenseKey;
    }

    /// <summary>
    /// This function uses the Reverse GeoCoder Cloud API object to make a GET request
    /// Multiple endpoints are tested
    /// </summary>
    public void ReverseGeoCoderSample()
    {
      ReverseGeoCoder reverseGeoCoder = new ReverseGeoCoder(licenseKey);
      reverseGeoCoder.SetLatitude("33.637520");
      reverseGeoCoder.SetLongitude("-117.606920");
      reverseGeoCoder.SetMaxRecords("3");

      string response = reverseGeoCoder.GetDoLookup<string>();
      ReverseGeoCoderResponse responseObject = reverseGeoCoder.GetDoLookup<ReverseGeoCoderResponse>();

      Console.WriteLine(response);

      Console.WriteLine($"\nVersion: {responseObject.Version}");
      Console.WriteLine($"TransmissionReference: {responseObject.TransmissionReference}");
      Console.WriteLine($"TransmissionResults: {responseObject.TransmissionResults}");
      Console.WriteLine($"Results: {responseObject.Results}");
      Console.WriteLine($"TotalRecords: {responseObject.TotalRecords}");
      foreach (var record in responseObject.Records)
      {
        Console.WriteLine(
          $"  AddressLine1: {record.AddressLine1}\n" +
          $"  SuiteName: {record.SuiteName}\n" +
          $"  SuiteCount: {record.SuiteCount}\n" +
          $"  City: {record.City}\n" +
          $"  State: {record.State}\n" +
          $"  PostalCode: {record.PostalCode}\n" +
          $"  AddressKey: {record.AddressKey}\n" +
          $"  Latitude: {record.Latitude}\n" +
          $"  Longitude: {record.Longitude}\n" +
          $"  Distance: {record.Distance}\n" +
          $"  MelissaAddressKey: {record.MelissaAddressKey}\n" +
          $"  MelissaAddressKeyBase: {record.MelissaAddressKeyBase}\n");
      }

      reverseGeoCoder.Clear();

      reverseGeoCoder.SetLatitude("33.637520");
      reverseGeoCoder.SetLongitude("-117.606920");
      reverseGeoCoder.SetMaxRecords("3");

      response = reverseGeoCoder.GetDoLookupPostalCodes<string>();
      responseObject = reverseGeoCoder.GetDoLookupPostalCodes<ReverseGeoCoderResponse>();

      Console.WriteLine(response);

      Console.WriteLine($"\nVersion: {responseObject.Version}");
      Console.WriteLine($"TransmissionReference: {responseObject.TransmissionReference}");
      Console.WriteLine($"TransmissionResults: {responseObject.TransmissionResults}");
      Console.WriteLine($"Results: {responseObject.Results}");
      Console.WriteLine($"TotalRecords: {responseObject.TotalRecords}");
      foreach (var record in responseObject.Records)
      {
        Console.WriteLine(
          $"  City: {record.City}\n" +
          $"  State: {record.State}\n" +
          $"  PostalCode: {record.PostalCode}\n" +
          $"  Latitude: {record.Latitude}\n" +
          $"  Longitude: {record.Longitude}\n" +
          $"  Distance: {record.Distance}\n");
      }
    }

    /// <summary>
    /// This asynchronous function uses the Reverse GeoCoder Cloud API object to make a GET request
    /// Multiple endpoints are tested
    /// </summary>
    public async Task ReverseGeoCoderAsyncSample()
    {
      ReverseGeoCoder reverseGeoCoder = new ReverseGeoCoder(licenseKey);
      reverseGeoCoder.SetLatitude("33.637520");
      reverseGeoCoder.SetLongitude("-117.606920");
      reverseGeoCoder.SetMaxRecords("3");

      string response = await reverseGeoCoder.GetDoLookupAsync<string>();
      ReverseGeoCoderResponse responseObject = await reverseGeoCoder.GetDoLookupAsync<ReverseGeoCoderResponse>();

      Console.WriteLine(response);

      Console.WriteLine($"\nVersion: {responseObject.Version}");
      Console.WriteLine($"TransmissionReference: {responseObject.TransmissionReference}");
      Console.WriteLine($"TransmissionResults: {responseObject.TransmissionResults}");
      Console.WriteLine($"Results: {responseObject.Results}");
      Console.WriteLine($"TotalRecords: {responseObject.TotalRecords}");
      foreach (var record in responseObject.Records)
      {
        Console.WriteLine(
          $"  AddressLine1: {record.AddressLine1}\n" +
          $"  SuiteName: {record.SuiteName}\n" +
          $"  SuiteCount: {record.SuiteCount}\n" +
          $"  City: {record.City}\n" +
          $"  State: {record.State}\n" +
          $"  PostalCode: {record.PostalCode}\n" +
          $"  AddressKey: {record.AddressKey}\n" +
          $"  Latitude: {record.Latitude}\n" +
          $"  Longitude: {record.Longitude}\n" +
          $"  Distance: {record.Distance}\n" +
          $"  MelissaAddressKey: {record.MelissaAddressKey}\n" +
          $"  MelissaAddressKeyBase: {record.MelissaAddressKeyBase}\n");
      }

      reverseGeoCoder.Clear();

      reverseGeoCoder.SetLatitude("33.637520");
      reverseGeoCoder.SetLongitude("-117.606920");
      reverseGeoCoder.SetMaxRecords("3");

      response = await reverseGeoCoder.GetDoLookupPostalCodesAsync<string>();
      responseObject = await reverseGeoCoder.GetDoLookupPostalCodesAsync<ReverseGeoCoderResponse>();

      Console.WriteLine(response);

      Console.WriteLine($"\nVersion: {responseObject.Version}");
      Console.WriteLine($"TransmissionReference: {responseObject.TransmissionReference}");
      Console.WriteLine($"TransmissionResults: {responseObject.TransmissionResults}");
      Console.WriteLine($"Results: {responseObject.Results}");
      Console.WriteLine($"TotalRecords: {responseObject.TotalRecords}");
      foreach (var record in responseObject.Records)
      {
        Console.WriteLine(
          $"  City: {record.City}\n" +
          $"  State: {record.State}\n" +
          $"  PostalCode: {record.PostalCode}\n" +
          $"  Latitude: {record.Latitude}\n" +
          $"  Longitude: {record.Longitude}\n" +
          $"  Distance: {record.Distance}\n");
      }
    }

    /// <summary>
    /// This function uses the Reverse GeoCoder Cloud API object to make a POST request
    /// Multiple endpoints are tested
    /// </summary>
    public void ReverseGeoCoderPost1Sample()
    {
      ReverseGeoCoder reverseGeoCoder = new ReverseGeoCoder();
      reverseGeoCoder.SetPostBody(new ReverseGeoCoderRecordRequest
      {
        CustomerId = licenseKey,
        Latitude = "33.63756710910554",
        Longitude = "-117.60695049134513",
        MaxRecords = "2"
      });

      string response = reverseGeoCoder.PostDoLookup<string>();
      ReverseGeoCoderResponse responseObject = reverseGeoCoder.PostDoLookup<ReverseGeoCoderResponse>();

      Console.WriteLine(response);

      Console.WriteLine($"\nVersion: {responseObject.Version}");
      Console.WriteLine($"TransmissionReference: {responseObject.TransmissionReference}");
      Console.WriteLine($"TransmissionResults: {responseObject.TransmissionResults}");
      Console.WriteLine($"Results: {responseObject.Results}");
      Console.WriteLine($"TotalRecords: {responseObject.TotalRecords}");
      foreach (var record in responseObject.Records)
      {
        Console.WriteLine(
          $"  AddressLine1: {record.AddressLine1}\n" +
          $"  SuiteName: {record.SuiteName}\n" +
          $"  SuiteCount: {record.SuiteCount}\n" +
          $"  City: {record.City}\n" +
          $"  State: {record.State}\n" +
          $"  PostalCode: {record.PostalCode}\n" +
          $"  AddressKey: {record.AddressKey}\n" +
          $"  Latitude: {record.Latitude}\n" +
          $"  Longitude: {record.Longitude}\n" +
          $"  Distance: {record.Distance}\n" +
          $"  MelissaAddressKey: {record.MelissaAddressKey}\n" +
          $"  MelissaAddressKeyBase: {record.MelissaAddressKeyBase}\n");
      }

      reverseGeoCoder.SetPostBody(new ReverseGeoCoderRecordRequest
      {
        CustomerId = licenseKey,
        Latitude = "33.63756710910554",
        Longitude = "-117.60695049134513",
        MaxRecords = "2"
      });

      response = reverseGeoCoder.PostDoLookupPostalCodes<string>();
      responseObject = reverseGeoCoder.PostDoLookupPostalCodes<ReverseGeoCoderResponse>();

      Console.WriteLine(response);

      Console.WriteLine($"\nVersion: {responseObject.Version}");
      Console.WriteLine($"TransmissionReference: {responseObject.TransmissionReference}");
      Console.WriteLine($"TransmissionResults: {responseObject.TransmissionResults}");
      Console.WriteLine($"Results: {responseObject.Results}");
      Console.WriteLine($"TotalRecords: {responseObject.TotalRecords}");
      foreach (var record in responseObject.Records)
      {
        Console.WriteLine(
          $"  City: {record.City}\n" +
          $"  State: {record.State}\n" +
          $"  PostalCode: {record.PostalCode}\n" +
          $"  Latitude: {record.Latitude}\n" +
          $"  Longitude: {record.Longitude}\n" +
          $"  Distance: {record.Distance}\n");
      }
    }

    /// <summary>
    /// This asynchronous function uses the Reverse GeoCoder Cloud API object to make a POST request
    /// Multiple endpoints are tested
    /// </summary>
    public async Task ReverseGeoCoderPost1AsyncSample()
    {
      ReverseGeoCoder reverseGeoCoder = new ReverseGeoCoder();
      reverseGeoCoder.SetPostBody(new ReverseGeoCoderRecordRequest
      {
        CustomerId = licenseKey,
        Latitude = "33.63756710910554",
        Longitude = "-117.60695049134513",
        MaxRecords = "2"
      });

      string response = await reverseGeoCoder.PostDoLookupAsync<string>();
      ReverseGeoCoderResponse responseObject = await reverseGeoCoder.PostDoLookupAsync<ReverseGeoCoderResponse>();

      Console.WriteLine(response);

      Console.WriteLine($"\nVersion: {responseObject.Version}");
      Console.WriteLine($"TransmissionReference: {responseObject.TransmissionReference}");
      Console.WriteLine($"TransmissionResults: {responseObject.TransmissionResults}");
      Console.WriteLine($"Results: {responseObject.Results}");
      Console.WriteLine($"TotalRecords: {responseObject.TotalRecords}");
      foreach (var record in responseObject.Records)
      {
        Console.WriteLine(
          $"  AddressLine1: {record.AddressLine1}\n" +
          $"  SuiteName: {record.SuiteName}\n" +
          $"  SuiteCount: {record.SuiteCount}\n" +
          $"  City: {record.City}\n" +
          $"  State: {record.State}\n" +
          $"  PostalCode: {record.PostalCode}\n" +
          $"  AddressKey: {record.AddressKey}\n" +
          $"  Latitude: {record.Latitude}\n" +
          $"  Longitude: {record.Longitude}\n" +
          $"  Distance: {record.Distance}\n" +
          $"  MelissaAddressKey: {record.MelissaAddressKey}\n" +
          $"  MelissaAddressKeyBase: {record.MelissaAddressKeyBase}\n");
      }

      reverseGeoCoder.SetPostBody(new ReverseGeoCoderRecordRequest
      {
        CustomerId = licenseKey,
        Latitude = "33.63756710910554",
        Longitude = "-117.60695049134513",
        MaxRecords = "2"
      });

      response = await reverseGeoCoder.PostDoLookupPostalCodesAsync<string>();
      responseObject = await reverseGeoCoder.PostDoLookupPostalCodesAsync<ReverseGeoCoderResponse>();

      Console.WriteLine(response);

      Console.WriteLine($"\nVersion: {responseObject.Version}");
      Console.WriteLine($"TransmissionReference: {responseObject.TransmissionReference}");
      Console.WriteLine($"TransmissionResults: {responseObject.TransmissionResults}");
      Console.WriteLine($"Results: {responseObject.Results}");
      Console.WriteLine($"TotalRecords: {responseObject.TotalRecords}");
      foreach (var record in responseObject.Records)
      {
        Console.WriteLine(
          $"  City: {record.City}\n" +
          $"  State: {record.State}\n" +
          $"  PostalCode: {record.PostalCode}\n" +
          $"  Latitude: {record.Latitude}\n" +
          $"  Longitude: {record.Longitude}\n" +
          $"  Distance: {record.Distance}\n");
      }
    }

    public void ReverseGeoCoderSetValueSample()
    {
      ReverseGeoCoder reverseGeoCoder = new ReverseGeoCoder(licenseKey);
      reverseGeoCoder.SetValue("Latitude", "33.637520");
      reverseGeoCoder.SetValue("Longitude", "-117.606920");
      reverseGeoCoder.SetValue("MaxRecords", "3");

      string response = reverseGeoCoder.GetDoLookup<string>();
      ReverseGeoCoderResponse responseObject = reverseGeoCoder.GetDoLookup<ReverseGeoCoderResponse>();

      Console.WriteLine(response);

      Console.WriteLine($"\nVersion: {responseObject.Version}");
      Console.WriteLine($"TransmissionReference: {responseObject.TransmissionReference}");
      Console.WriteLine($"TransmissionResults: {responseObject.TransmissionResults}");
      Console.WriteLine($"Results: {responseObject.Results}");
      Console.WriteLine($"TotalRecords: {responseObject.TotalRecords}");
      foreach (var record in responseObject.Records)
      {
        Console.WriteLine(
          $"  AddressLine1: {record.AddressLine1}\n" +
          $"  SuiteName: {record.SuiteName}\n" +
          $"  SuiteCount: {record.SuiteCount}\n" +
          $"  City: {record.City}\n" +
          $"  State: {record.State}\n" +
          $"  PostalCode: {record.PostalCode}\n" +
          $"  AddressKey: {record.AddressKey}\n" +
          $"  Latitude: {record.Latitude}\n" +
          $"  Longitude: {record.Longitude}\n" +
          $"  Distance: {record.Distance}\n" +
          $"  MelissaAddressKey: {record.MelissaAddressKey}\n" +
          $"  MelissaAddressKeyBase: {record.MelissaAddressKeyBase}\n");
      }

    }
  }
}
