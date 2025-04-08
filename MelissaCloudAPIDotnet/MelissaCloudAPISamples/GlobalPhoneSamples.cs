using MelissaData.CloudAPI;

namespace MelissaCloudAPIDotnet.MelissaCloudAPISamples
{
  public class GlobalPhoneSamples
  {
    public string licenseKey;

    public GlobalPhoneSamples(string licenseKey)
    {
      this.licenseKey = licenseKey;
    }

    /// <summary>
    /// This function uses the Global Phone Cloud API object to make a GET request
    /// </summary>
    public void GlobalPhoneSample()
    {
      GlobalPhone globalPhone = new GlobalPhone(licenseKey);
      globalPhone.SetPhone("800-635-4772");

      string response = globalPhone.Get<string>();
      GlobalPhoneResponse responseObject = globalPhone.Get<GlobalPhoneResponse>();

      Console.WriteLine(response);

      Console.WriteLine($"\nVersion: {responseObject.Version}");
      Console.WriteLine($"TransmissionReference: {responseObject.TransmissionReference}");
      Console.WriteLine($"TransmissionResults: {responseObject.TransmissionResults}");
      Console.WriteLine($"TotalRecords: {responseObject.TotalRecords}\n");
      foreach (var record in responseObject.Records)
      {
        Console.WriteLine("RecordID: " + record.RecordID);
        Console.WriteLine("Results: " + record.Results);
        Console.WriteLine("PhoneNumber: " + record.PhoneNumber);
        Console.WriteLine("AdministrativeArea: " + record.AdministrativeArea);
        Console.WriteLine("CountryAbbreviation: " + record.CountryAbbreviation);
        Console.WriteLine("CountryName: " + record.CountryName);
        Console.WriteLine("Carrier: " + record.Carrier);
        Console.WriteLine("CallerID: " + record.CallerID);
        Console.WriteLine("DST: " + record.DST);
        Console.WriteLine("InternationalPhoneNumber: " + record.InternationalPhoneNumber);
        Console.WriteLine("Language: " + record.Language);
        Console.WriteLine("Latitude: " + record.Latitude);
        Console.WriteLine("Locality: " + record.Locality);
        Console.WriteLine("Longitude: " + record.Longitude);
        Console.WriteLine("PhoneInternationalPrefix: " + record.PhoneInternationalPrefix);
        Console.WriteLine("PhoneCountryDialingCode: " + record.PhoneCountryDialingCode);
        Console.WriteLine("PhoneNationPrefix: " + record.PhoneNationPrefix);
        Console.WriteLine("PhoneNationalDestinationCode: " + record.PhoneNationalDestinationCode);
        Console.WriteLine("PhoneSubscriberNumber: " + record.PhoneSubscriberNumber);
        Console.WriteLine("UTC: " + record.UTC);
        Console.WriteLine("TimeZoneCode: " + record.TimeZoneCode);
        Console.WriteLine("TimeZoneName: " + record.TimeZoneName);
        Console.WriteLine("PostalCode: " + record.PostalCode);
        Console.WriteLine("Suggestions: " + record.Suggestions + "\n\n");
      }
    }

    /// <summary>
    /// This asynchronous function uses the Global Phone Cloud API object to make a GET request
    /// </summary>
    public async Task GlobalPhoneAsyncSample()
    {
      GlobalPhone globalPhone = new GlobalPhone(licenseKey);
      globalPhone.SetPhone("800-635-4772");

      string response = globalPhone.Get<string>();
      GlobalPhoneResponse responseObject = globalPhone.Get<GlobalPhoneResponse>();

      Console.WriteLine(response);

      Console.WriteLine($"\nVersion: {responseObject.Version}");
      Console.WriteLine($"TransmissionReference: {responseObject.TransmissionReference}");
      Console.WriteLine($"TransmissionResults: {responseObject.TransmissionResults}");
      Console.WriteLine($"TotalRecords: {responseObject.TotalRecords}\n");
      foreach (var record in responseObject.Records)
      {
        Console.WriteLine("RecordID: " + record.RecordID);
        Console.WriteLine("Results: " + record.Results);
        Console.WriteLine("PhoneNumber: " + record.PhoneNumber);
        Console.WriteLine("AdministrativeArea: " + record.AdministrativeArea);
        Console.WriteLine("CountryAbbreviation: " + record.CountryAbbreviation);
        Console.WriteLine("CountryName: " + record.CountryName);
        Console.WriteLine("Carrier: " + record.Carrier);
        Console.WriteLine("CallerID: " + record.CallerID);
        Console.WriteLine("DST: " + record.DST);
        Console.WriteLine("InternationalPhoneNumber: " + record.InternationalPhoneNumber);
        Console.WriteLine("Language: " + record.Language);
        Console.WriteLine("Latitude: " + record.Latitude);
        Console.WriteLine("Locality: " + record.Locality);
        Console.WriteLine("Longitude: " + record.Longitude);
        Console.WriteLine("PhoneInternationalPrefix: " + record.PhoneInternationalPrefix);
        Console.WriteLine("PhoneCountryDialingCode: " + record.PhoneCountryDialingCode);
        Console.WriteLine("PhoneNationPrefix: " + record.PhoneNationPrefix);
        Console.WriteLine("PhoneNationalDestinationCode: " + record.PhoneNationalDestinationCode);
        Console.WriteLine("PhoneSubscriberNumber: " + record.PhoneSubscriberNumber);
        Console.WriteLine("UTC: " + record.UTC);
        Console.WriteLine("TimeZoneCode: " + record.TimeZoneCode);
        Console.WriteLine("TimeZoneName: " + record.TimeZoneName);
        Console.WriteLine("PostalCode: " + record.PostalCode);
        Console.WriteLine("Suggestions: " + record.Suggestions + "\n\n");
      }
    }

    /// <summary>
    /// This function uses the Global Phone Cloud API object to make a POST BATCH request
    /// This function showcases method 1 of setting and making POST requests: construct the POST body structure using the Cloud API's respective PostRequest class
    /// </summary>

    public void GlobalPhoneBatch1Sample()
    {
      GlobalPhone globalPhone = new GlobalPhone();
      globalPhone.SetPostBody(new GlobalPhonePostRequest
      {
        CustomerID = licenseKey,
        Records = new List<GlobalPhoneRecordRequest>
        {
          new GlobalPhoneRecordRequest
          {
             RecordID = "1",
             PhoneNumber = "800-635-4772"
          },
          new GlobalPhoneRecordRequest
          {
             RecordID = "2",
             PhoneNumber = "+49 (0) 221 97 58 92 40"
          }
        }
      });

      string response = globalPhone.Post<string>();
      GlobalPhoneResponse responseObject = globalPhone.Post<GlobalPhoneResponse>();

      Console.WriteLine(response);

      Console.WriteLine($"\nVersion: {responseObject.Version}");
      Console.WriteLine($"TransmissionReference: {responseObject.TransmissionReference}");
      Console.WriteLine($"TransmissionResults: {responseObject.TransmissionResults}");
      Console.WriteLine($"TotalRecords: {responseObject.TotalRecords}\n");
      foreach (var record in responseObject.Records)
      {
        Console.WriteLine("RecordID: " + record.RecordID);
        Console.WriteLine("Results: " + record.Results);
        Console.WriteLine("PhoneNumber: " + record.PhoneNumber);
        Console.WriteLine("AdministrativeArea: " + record.AdministrativeArea);
        Console.WriteLine("CountryAbbreviation: " + record.CountryAbbreviation);
        Console.WriteLine("CountryName: " + record.CountryName);
        Console.WriteLine("Carrier: " + record.Carrier);
        Console.WriteLine("CallerID: " + record.CallerID);
        Console.WriteLine("DST: " + record.DST);
        Console.WriteLine("InternationalPhoneNumber: " + record.InternationalPhoneNumber);
        Console.WriteLine("Language: " + record.Language);
        Console.WriteLine("Latitude: " + record.Latitude);
        Console.WriteLine("Locality: " + record.Locality);
        Console.WriteLine("Longitude: " + record.Longitude);
        Console.WriteLine("PhoneInternationalPrefix: " + record.PhoneInternationalPrefix);
        Console.WriteLine("PhoneCountryDialingCode: " + record.PhoneCountryDialingCode);
        Console.WriteLine("PhoneNationPrefix: " + record.PhoneNationPrefix);
        Console.WriteLine("PhoneNationalDestinationCode: " + record.PhoneNationalDestinationCode);
        Console.WriteLine("PhoneSubscriberNumber: " + record.PhoneSubscriberNumber);
        Console.WriteLine("UTC: " + record.UTC);
        Console.WriteLine("TimeZoneCode: " + record.TimeZoneCode);
        Console.WriteLine("TimeZoneName: " + record.TimeZoneName);
        Console.WriteLine("PostalCode: " + record.PostalCode);
        Console.WriteLine("Suggestions: " + record.Suggestions + "\n\n");
      }
    }

    /// <summary>
    /// This function uses the Global Phone Cloud API object to make a POST BATCH request
    /// This function showcases method 2 of setting and making POST requests: construct the POST body record by using the Cloud API's respective RecordRequest class
    /// </summary>
    public void GlobalPhoneBatch2Sample()
    {
      GlobalPhone globalPhone = new GlobalPhone(licenseKey);
      globalPhone.AddRecord(new GlobalPhoneRecordRequest { RecordID = "1", PhoneNumber = "800-635-4772" });
      globalPhone.AddRecord(new GlobalPhoneRecordRequest { RecordID = "2", PhoneNumber = "+49 (0) 221 97 58 92 40" });

      string response = globalPhone.Post<string>();
      GlobalPhoneResponse responseObject = globalPhone.Post<GlobalPhoneResponse>();

      Console.WriteLine(response);

      Console.WriteLine($"\nVersion: {responseObject.Version}");
      Console.WriteLine($"TransmissionReference: {responseObject.TransmissionReference}");
      Console.WriteLine($"TransmissionResults: {responseObject.TransmissionResults}");
      Console.WriteLine($"TotalRecords: {responseObject.TotalRecords}\n");
      foreach (var record in responseObject.Records)
      {
        Console.WriteLine("RecordID: " + record.RecordID);
        Console.WriteLine("Results: " + record.Results);
        Console.WriteLine("PhoneNumber: " + record.PhoneNumber);
        Console.WriteLine("AdministrativeArea: " + record.AdministrativeArea);
        Console.WriteLine("CountryAbbreviation: " + record.CountryAbbreviation);
        Console.WriteLine("CountryName: " + record.CountryName);
        Console.WriteLine("Carrier: " + record.Carrier);
        Console.WriteLine("CallerID: " + record.CallerID);
        Console.WriteLine("DST: " + record.DST);
        Console.WriteLine("InternationalPhoneNumber: " + record.InternationalPhoneNumber);
        Console.WriteLine("Language: " + record.Language);
        Console.WriteLine("Latitude: " + record.Latitude);
        Console.WriteLine("Locality: " + record.Locality);
        Console.WriteLine("Longitude: " + record.Longitude);
        Console.WriteLine("PhoneInternationalPrefix: " + record.PhoneInternationalPrefix);
        Console.WriteLine("PhoneCountryDialingCode: " + record.PhoneCountryDialingCode);
        Console.WriteLine("PhoneNationPrefix: " + record.PhoneNationPrefix);
        Console.WriteLine("PhoneNationalDestinationCode: " + record.PhoneNationalDestinationCode);
        Console.WriteLine("PhoneSubscriberNumber: " + record.PhoneSubscriberNumber);
        Console.WriteLine("UTC: " + record.UTC);
        Console.WriteLine("TimeZoneCode: " + record.TimeZoneCode);
        Console.WriteLine("TimeZoneName: " + record.TimeZoneName);
        Console.WriteLine("PostalCode: " + record.PostalCode);
        Console.WriteLine("Suggestions: " + record.Suggestions + "\n\n");
      }
    }

    /// <summary>
    /// This asynchronous function uses the Global Address Verification Cloud API object to make a POST request
    /// </summary>

    public async Task GlobalPhoneBatchAsyncSample()
    {
      GlobalPhone globalPhone = new GlobalPhone();
      globalPhone.SetPostBody(new GlobalPhonePostRequest
      {
        CustomerID = licenseKey,
        Records = new List<GlobalPhoneRecordRequest>
        {
          new GlobalPhoneRecordRequest
          {
             RecordID = "1",
             PhoneNumber = "800-635-4772"
          },
          new GlobalPhoneRecordRequest
          {
             RecordID = "2",
             PhoneNumber = "+49 (0) 221 97 58 92 40"
          }
        }
      });

      string response = await globalPhone.PostAsync<string>();
      GlobalPhoneResponse responseObject = await globalPhone.PostAsync<GlobalPhoneResponse>();

      Console.WriteLine(response);

      Console.WriteLine($"\nVersion: {responseObject.Version}");
      Console.WriteLine($"TransmissionReference: {responseObject.TransmissionReference}");
      Console.WriteLine($"TransmissionResults: {responseObject.TransmissionResults}");
      Console.WriteLine($"TotalRecords: {responseObject.TotalRecords}\n");
      foreach (var record in responseObject.Records)
      {
        Console.WriteLine("RecordID: " + record.RecordID);
        Console.WriteLine("Results: " + record.Results);
        Console.WriteLine("PhoneNumber: " + record.PhoneNumber);
        Console.WriteLine("AdministrativeArea: " + record.AdministrativeArea);
        Console.WriteLine("CountryAbbreviation: " + record.CountryAbbreviation);
        Console.WriteLine("CountryName: " + record.CountryName);
        Console.WriteLine("Carrier: " + record.Carrier);
        Console.WriteLine("CallerID: " + record.CallerID);
        Console.WriteLine("DST: " + record.DST);
        Console.WriteLine("InternationalPhoneNumber: " + record.InternationalPhoneNumber);
        Console.WriteLine("Language: " + record.Language);
        Console.WriteLine("Latitude: " + record.Latitude);
        Console.WriteLine("Locality: " + record.Locality);
        Console.WriteLine("Longitude: " + record.Longitude);
        Console.WriteLine("PhoneInternationalPrefix: " + record.PhoneInternationalPrefix);
        Console.WriteLine("PhoneCountryDialingCode: " + record.PhoneCountryDialingCode);
        Console.WriteLine("PhoneNationPrefix: " + record.PhoneNationPrefix);
        Console.WriteLine("PhoneNationalDestinationCode: " + record.PhoneNationalDestinationCode);
        Console.WriteLine("PhoneSubscriberNumber: " + record.PhoneSubscriberNumber);
        Console.WriteLine("UTC: " + record.UTC);
        Console.WriteLine("TimeZoneCode: " + record.TimeZoneCode);
        Console.WriteLine("TimeZoneName: " + record.TimeZoneName);
        Console.WriteLine("PostalCode: " + record.PostalCode);
        Console.WriteLine("Suggestions: " + record.Suggestions + "\n\n");
      }
    }

    public void GlobalPhoneSetValueSample()
    {
      GlobalPhone globalPhone = new GlobalPhone(licenseKey);
      globalPhone.SetValue("Phone", "800-635-4772");

      string response = globalPhone.Get<string>();
      GlobalPhoneResponse responseObject = globalPhone.Get<GlobalPhoneResponse>();

      Console.WriteLine(response);

      Console.WriteLine($"\nVersion: {responseObject.Version}");
      Console.WriteLine($"TransmissionReference: {responseObject.TransmissionReference}");
      Console.WriteLine($"TransmissionResults: {responseObject.TransmissionResults}");
      Console.WriteLine($"TotalRecords: {responseObject.TotalRecords}\n");
      foreach (var record in responseObject.Records)
      {
        Console.WriteLine("RecordID: " + record.RecordID);
        Console.WriteLine("Results: " + record.Results);
        Console.WriteLine("PhoneNumber: " + record.PhoneNumber);
        Console.WriteLine("AdministrativeArea: " + record.AdministrativeArea);
        Console.WriteLine("CountryAbbreviation: " + record.CountryAbbreviation);
        Console.WriteLine("CountryName: " + record.CountryName);
        Console.WriteLine("Carrier: " + record.Carrier);
        Console.WriteLine("CallerID: " + record.CallerID);
        Console.WriteLine("DST: " + record.DST);
        Console.WriteLine("InternationalPhoneNumber: " + record.InternationalPhoneNumber);
        Console.WriteLine("Language: " + record.Language);
        Console.WriteLine("Latitude: " + record.Latitude);
        Console.WriteLine("Locality: " + record.Locality);
        Console.WriteLine("Longitude: " + record.Longitude);
        Console.WriteLine("PhoneInternationalPrefix: " + record.PhoneInternationalPrefix);
        Console.WriteLine("PhoneCountryDialingCode: " + record.PhoneCountryDialingCode);
        Console.WriteLine("PhoneNationPrefix: " + record.PhoneNationPrefix);
        Console.WriteLine("PhoneNationalDestinationCode: " + record.PhoneNationalDestinationCode);
        Console.WriteLine("PhoneSubscriberNumber: " + record.PhoneSubscriberNumber);
        Console.WriteLine("UTC: " + record.UTC);
        Console.WriteLine("TimeZoneCode: " + record.TimeZoneCode);
        Console.WriteLine("TimeZoneName: " + record.TimeZoneName);
        Console.WriteLine("PostalCode: " + record.PostalCode);
        Console.WriteLine("Suggestions: " + record.Suggestions + "\n\n");
      }
    }

    public void GlobalPhoneSetValueSample2()
    {
      GlobalPhone globalPhone = new GlobalPhone(licenseKey);
      globalPhone.Phone = "800-635-4772";

      string response = globalPhone.Get<string>();
      GlobalPhoneResponse responseObject = globalPhone.Get<GlobalPhoneResponse>();

      Console.WriteLine(response);

      Console.WriteLine($"\nVersion: {responseObject.Version}");
      Console.WriteLine($"TransmissionReference: {responseObject.TransmissionReference}");
      Console.WriteLine($"TransmissionResults: {responseObject.TransmissionResults}");
      Console.WriteLine($"TotalRecords: {responseObject.TotalRecords}\n");
      foreach (var record in responseObject.Records)
      {
        Console.WriteLine("RecordID: " + record.RecordID);
        Console.WriteLine("Results: " + record.Results);
        Console.WriteLine("PhoneNumber: " + record.PhoneNumber);
        Console.WriteLine("AdministrativeArea: " + record.AdministrativeArea);
        Console.WriteLine("CountryAbbreviation: " + record.CountryAbbreviation);
        Console.WriteLine("CountryName: " + record.CountryName);
        Console.WriteLine("Carrier: " + record.Carrier);
        Console.WriteLine("CallerID: " + record.CallerID);
        Console.WriteLine("DST: " + record.DST);
        Console.WriteLine("InternationalPhoneNumber: " + record.InternationalPhoneNumber);
        Console.WriteLine("Language: " + record.Language);
        Console.WriteLine("Latitude: " + record.Latitude);
        Console.WriteLine("Locality: " + record.Locality);
        Console.WriteLine("Longitude: " + record.Longitude);
        Console.WriteLine("PhoneInternationalPrefix: " + record.PhoneInternationalPrefix);
        Console.WriteLine("PhoneCountryDialingCode: " + record.PhoneCountryDialingCode);
        Console.WriteLine("PhoneNationPrefix: " + record.PhoneNationPrefix);
        Console.WriteLine("PhoneNationalDestinationCode: " + record.PhoneNationalDestinationCode);
        Console.WriteLine("PhoneSubscriberNumber: " + record.PhoneSubscriberNumber);
        Console.WriteLine("UTC: " + record.UTC);
        Console.WriteLine("TimeZoneCode: " + record.TimeZoneCode);
        Console.WriteLine("TimeZoneName: " + record.TimeZoneName);
        Console.WriteLine("PostalCode: " + record.PostalCode);
        Console.WriteLine("Suggestions: " + record.Suggestions + "\n\n");
      }
    }
  }
}
