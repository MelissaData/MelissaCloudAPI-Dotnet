using MelissaData.CloudAPI;

namespace MelissaCloudAPIDotnet.MelissaCloudAPISamples
{
  public class BusinessCoderSamples
  {
    public string licenseKey;

    public BusinessCoderSamples(string licenseKey)
    {
      this.licenseKey = licenseKey;
    }

    /// <summary>
    /// This function uses the Business Coder Cloud API object to make a GET request
    /// </summary>

    public void BusinessCoderSample()
    {
      BusinessCoder businessCoder = new BusinessCoder(licenseKey);
      businessCoder.SetCompany("Melissa");
      businessCoder.SetAddressLine1("22382 Avenida Empresa");
      businessCoder.SetCity("Rancho Santa Margarita");
      businessCoder.SetState("CA");
      businessCoder.SetPostal("92688");
      businessCoder.SetCountry("United States");
      //businessCoder.SetCols("GrpAddressDetails,GrpBusinessCodes,Contacts");

      string response = businessCoder.Get<string>();
      BusinessCoderResponse responseObject = businessCoder.Get<BusinessCoderResponse>();

      Console.WriteLine(response);

      Console.WriteLine($"\nVersion: {responseObject.Version}");
      Console.WriteLine($"TransmissionReference: {responseObject.TransmissionReference}");
      Console.WriteLine($"TotalRecords: {responseObject.TotalRecords}\n");
      foreach (var record in responseObject.Records)
      {
        Console.WriteLine("AddressLine1: " + record.AddressLine1);
        Console.WriteLine("City: " + record.City);
        Console.WriteLine("CompanyName: " + record.CompanyName);
        Console.WriteLine("CurrentCompanyName: " + record.CurrentCompanyName);
        Console.WriteLine("MelissaEnterpriseKey: " + record.MelissaEnterpriseKey);
        Console.WriteLine("PostalCode: " + record.PostalCode);
        Console.WriteLine("RecordID: " + record.RecordID);
        Console.WriteLine("Results: " + record.Results);
        Console.WriteLine("State: " + record.State);
        Console.WriteLine("Suite: " + record.Suite);
        Console.WriteLine("TotalContacts: " + record.TotalContacts);
      }
    }

    /// <summary>
    /// This asynchronous function uses the Business Coder Cloud API object to make a GET request
    /// </summary>

    public async Task BusinessCoderAsyncSample()
    {
      BusinessCoder businessCoder = new BusinessCoder(licenseKey);
      businessCoder.SetCompany("Melissa");
      businessCoder.SetAddressLine1("22382 Avenida Empresa");
      businessCoder.SetCity("Rancho Santa Margarita");
      businessCoder.SetState("CA");
      businessCoder.SetPostal("92688");
      businessCoder.SetCountry("United States");

      string response = businessCoder.Get<string>();
      BusinessCoderResponse responseObject = businessCoder.Get<BusinessCoderResponse>();

      Console.WriteLine(response);

      Console.WriteLine($"\nVersion: {responseObject.Version}");
      Console.WriteLine($"TransmissionReference: {responseObject.TransmissionReference}");
      Console.WriteLine($"TotalRecords: {responseObject.TotalRecords}\n");
      foreach (var record in responseObject.Records)
      {
        Console.WriteLine("AddressLine1: " + record.AddressLine1);
        Console.WriteLine("City: " + record.City);
        Console.WriteLine("CompanyName: " + record.CompanyName);
        Console.WriteLine("CurrentCompanyName: " + record.CurrentCompanyName);
        Console.WriteLine("MelissaEnterpriseKey: " + record.MelissaEnterpriseKey);
        Console.WriteLine("PostalCode: " + record.PostalCode);
        Console.WriteLine("RecordID: " + record.RecordID);
        Console.WriteLine("Results: " + record.Results);
        Console.WriteLine("State: " + record.State);
        Console.WriteLine("Suite: " + record.Suite);
        Console.WriteLine("TotalContacts: " + record.TotalContacts);
      }
    }

    /// <summary>
    /// This function uses the Business Coder Cloud API object to make a POST BATCH request
    /// This function showcases method 1 of setting and making POST requests: construct the POST body structure using the Cloud API's respective PostRequest class
    /// </summary>
    public void BusinessCoderBatch1Sample()
    {
      BusinessCoder businessCoder = new BusinessCoder();
      businessCoder.SetPostBody(new BusinessCoderPostRequest
      {
        Id = licenseKey,
        Records = new List<BusinessCoderRecordRequest>
        {
          new BusinessCoderRecordRequest
          {
            A1 = "22382 Avenida Empresa",
            City = "Rancho Santa Margarita",
            Postal = "92688",
            State = "California"
          },
          new BusinessCoderRecordRequest
          {
            A1 = "1 Microsoft Way",
            City = "Redmond",
            Postal = "98052",
            State = "Washington"
          },
        }
      });

      string response = businessCoder.Post<string>();
      BusinessCoderResponse responseObject = businessCoder.Post<BusinessCoderResponse>();

      Console.WriteLine(response);

      Console.WriteLine($"\nVersion: {responseObject.Version}");
      Console.WriteLine($"TransmissionReference: {responseObject.TransmissionReference}");
      Console.WriteLine($"TotalRecords: {responseObject.TotalRecords}\n");
      foreach (var record in responseObject.Records)
      {
        Console.WriteLine("AddressLine1: " + record.AddressLine1);
        Console.WriteLine("City: " + record.City);
        Console.WriteLine("CompanyName: " + record.CompanyName);
        Console.WriteLine("CurrentCompanyName: " + record.CurrentCompanyName);
        Console.WriteLine("MelissaEnterpriseKey: " + record.MelissaEnterpriseKey);
        Console.WriteLine("PostalCode: " + record.PostalCode);
        Console.WriteLine("RecordID: " + record.RecordID);
        Console.WriteLine("Results: " + record.Results);
        Console.WriteLine("State: " + record.State);
        Console.WriteLine("Suite: " + record.Suite);
        Console.WriteLine("TotalContacts: " + record.TotalContacts + "\n");
      }
    }

    /// <summary>
    /// This function uses the Business Coder Cloud API object to make a POST BATCH request
    /// This function showcases method 2 of setting and making POST requests: construct the POST body record by using the Cloud API's respective RecordRequest class
    /// </summary>
    public void BusinessCoderBatch2Sample()
    {
      BusinessCoder businessCoder = new BusinessCoder(licenseKey);
      businessCoder.AddRecord(
        new BusinessCoderRecordRequest
        {
          A1 = "22382 Avenida Empresa",
          City = "Rancho Santa Margarita",
          Postal = "92688",
          State = "California"
        }
      );

      businessCoder.AddRecord(
        new BusinessCoderRecordRequest
        {
          A1 = "1 Microsoft Way",
          City = "Redmond",
          Postal = "98052",
          State = "Washington"
        }
      );

      string response = businessCoder.Post<string>();
      BusinessCoderResponse responseObject = businessCoder.Post<BusinessCoderResponse>();

      Console.WriteLine(response);

      Console.WriteLine($"\nVersion: {responseObject.Version}");
      Console.WriteLine($"TransmissionReference: {responseObject.TransmissionReference}");
      Console.WriteLine($"TotalRecords: {responseObject.TotalRecords}\n");
      foreach (var record in responseObject.Records)
      {
        Console.WriteLine("AddressLine1: " + record.AddressLine1);
        Console.WriteLine("City: " + record.City);
        Console.WriteLine("CompanyName: " + record.CompanyName);
        Console.WriteLine("CurrentCompanyName: " + record.CurrentCompanyName);
        Console.WriteLine("MelissaEnterpriseKey: " + record.MelissaEnterpriseKey);
        Console.WriteLine("PostalCode: " + record.PostalCode);
        Console.WriteLine("RecordID: " + record.RecordID);
        Console.WriteLine("Results: " + record.Results);
        Console.WriteLine("State: " + record.State);
        Console.WriteLine("Suite: " + record.Suite);
        Console.WriteLine("TotalContacts: " + record.TotalContacts + "\n");
      }
    }

    /// <summary>
    /// This asynchronous function uses the Global Address Verification Cloud API object to make a POST request
    /// </summary>
    public async Task BusinessCoderBatchAsyncSample()
    {
      BusinessCoder businessCoder = new BusinessCoder();
      businessCoder.SetPostBody(new BusinessCoderPostRequest
      {
        Id = licenseKey,
        Records = new List<BusinessCoderRecordRequest>
        {
          new BusinessCoderRecordRequest
          {
            A1 = "22382 Avenida Empresa",
            City = "Rancho Santa Margarita",
            Postal = "92688",
            State = "California"
          },
          new BusinessCoderRecordRequest
          {
            A1 = "1 Microsoft Way",
            City = "Redmond",
            Postal = "98052",
            State = "Washington"
          },
        }
      });

      string response = await businessCoder.PostAsync<string>();
      BusinessCoderResponse responseObject = await businessCoder.PostAsync<BusinessCoderResponse>();

      Console.WriteLine(response);

      Console.WriteLine($"\nVersion: {responseObject.Version}");
      Console.WriteLine($"TransmissionReference: {responseObject.TransmissionReference}");
      Console.WriteLine($"TotalRecords: {responseObject.TotalRecords}\n");
      foreach (var record in responseObject.Records)
      {
        Console.WriteLine("AddressLine1: " + record.AddressLine1);
        Console.WriteLine("City: " + record.City);
        Console.WriteLine("CompanyName: " + record.CompanyName);
        Console.WriteLine("CurrentCompanyName: " + record.CurrentCompanyName);
        Console.WriteLine("MelissaEnterpriseKey: " + record.MelissaEnterpriseKey);
        Console.WriteLine("PostalCode: " + record.PostalCode);
        Console.WriteLine("RecordID: " + record.RecordID);
        Console.WriteLine("Results: " + record.Results);
        Console.WriteLine("State: " + record.State);
        Console.WriteLine("Suite: " + record.Suite);
        Console.WriteLine("TotalContacts: " + record.TotalContacts + "\n");
      }
    }

    public void BusinessCoderSetValueSample()
    {
      BusinessCoder businessCoder = new BusinessCoder(licenseKey);
      businessCoder.SetValue("Company", "Melissa");
      businessCoder.SetValue("AddressLine1", "22382 Avenida Empresa");
      businessCoder.SetValue("City", "Rancho Santa Margarita");
      businessCoder.SetValue("State", "CA");
      businessCoder.SetValue("Postal", "92688");
      businessCoder.SetValue("Country", "United States");

      string response = businessCoder.Get<string>();
      BusinessCoderResponse responseObject = businessCoder.Get<BusinessCoderResponse>();

      Console.WriteLine(response);

      Console.WriteLine($"\nVersion: {responseObject.Version}");
      Console.WriteLine($"TransmissionReference: {responseObject.TransmissionReference}");
      Console.WriteLine($"TotalRecords: {responseObject.TotalRecords}\n");
      foreach (var record in responseObject.Records)
      {
        Console.WriteLine("AddressLine1: " + record.AddressLine1);
        Console.WriteLine("City: " + record.City);
        Console.WriteLine("CompanyName: " + record.CompanyName);
        Console.WriteLine("CurrentCompanyName: " + record.CurrentCompanyName);
        Console.WriteLine("MelissaEnterpriseKey: " + record.MelissaEnterpriseKey);
        Console.WriteLine("PostalCode: " + record.PostalCode);
        Console.WriteLine("RecordID: " + record.RecordID);
        Console.WriteLine("Results: " + record.Results);
        Console.WriteLine("State: " + record.State);
        Console.WriteLine("Suite: " + record.Suite);
        Console.WriteLine("TotalContacts: " + record.TotalContacts);
      }
    }

    public void BusinessCoderSetValueSample2()
    {
      BusinessCoder businessCoder = new BusinessCoder(licenseKey);
      businessCoder.Company = "Melissa";
      businessCoder.AddressLine1 = "22382 Avenida Empresa";
      businessCoder.City = "Rancho Santa Margarita";
      businessCoder.State = "CA";
      businessCoder.Postal = "92688";
      businessCoder.Country = "United States"; ;

      string response = businessCoder.Get<string>();
      BusinessCoderResponse responseObject = businessCoder.Get<BusinessCoderResponse>();

      Console.WriteLine(response);

      Console.WriteLine($"\nVersion: {responseObject.Version}");
      Console.WriteLine($"TransmissionReference: {responseObject.TransmissionReference}");
      Console.WriteLine($"TotalRecords: {responseObject.TotalRecords}\n");
      foreach (var record in responseObject.Records)
      {
        Console.WriteLine("AddressLine1: " + record.AddressLine1);
        Console.WriteLine("City: " + record.City);
        Console.WriteLine("CompanyName: " + record.CompanyName);
        Console.WriteLine("CurrentCompanyName: " + record.CurrentCompanyName);
        Console.WriteLine("MelissaEnterpriseKey: " + record.MelissaEnterpriseKey);
        Console.WriteLine("PostalCode: " + record.PostalCode);
        Console.WriteLine("RecordID: " + record.RecordID);
        Console.WriteLine("Results: " + record.Results);
        Console.WriteLine("State: " + record.State);
        Console.WriteLine("Suite: " + record.Suite);
        Console.WriteLine("TotalContacts: " + record.TotalContacts);
      }
    }
  }
}
