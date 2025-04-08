using MelissaData.CloudAPI;

namespace MelissaCloudAPIDotnet.MelissaCloudAPISamples
{
  public class SmartMoverSamples
  {
    public string licenseKey;
    public string pafId;

    public SmartMoverSamples(string licenseKey, string pafId)
    {
      this.licenseKey = licenseKey;
      this.pafId = pafId;
    }

    /// <summary>
    /// This function uses the Smart Mover Cloud API object to make a GET request
    /// </summary>
    public void SmartMoverSample()
    {
      SmartMover smartMover = new SmartMover(licenseKey);
      smartMover.SetPafID(pafId);
      smartMover.SetCompany("Melissa");
      smartMover.SetFullName("Ray Melissa");
      smartMover.SetAddressLine1("22382 Avenida Empresa");
      smartMover.SetCity("Rancho Santa Margarita");
      smartMover.SetState("CA");
      smartMover.SetPostal("92688");
      smartMover.SetCountry("US");
      smartMover.SetCols("grpParsed");

      string response = smartMover.Get<string>();
      SmartMoverResponse responseObject = smartMover.Get<SmartMoverResponse>();

      Console.WriteLine(response);

      Console.WriteLine($"\nTotalRecords: {responseObject.TotalRecords}");
      Console.WriteLine($"TransmissionReference: {responseObject.TransmissionReference}");
      Console.WriteLine($"TransmissionResults: {responseObject.TransmissionResults}");
      Console.WriteLine($"Version: {responseObject.Version}");
      foreach (var record in responseObject.Records)
      {
        Console.WriteLine($"\nAddressHouseNumber: {record.AddressHouseNumber}");
        Console.WriteLine($"AddressKey: {record.AddressKey}");
        Console.WriteLine($"AddressLine1: {record.AddressLine1}");
        Console.WriteLine($"AddressStreetName: {record.AddressStreetName}");
        Console.WriteLine($"AddressTypeCode: {record.AddressTypeCode}");
        Console.WriteLine($"CarrierRoute: {record.CarrierRoute}");
        Console.WriteLine($"City: {record.City}");
        Console.WriteLine($"CityAbbreviation: {record.CityAbbreviation}");
        Console.WriteLine($"CompanyName: {record.CompanyName}");
        Console.WriteLine($"CountryCode: {record.CountryCode}");
        Console.WriteLine($"CountryName: {record.CountryName}");
        Console.WriteLine($"DeliveryIndicator: {record.DeliveryIndicator}");
        Console.WriteLine($"DeliveryPointCheckDigit: {record.DeliveryPointCheckDigit}");
        Console.WriteLine($"DeliveryPointCode: {record.DeliveryPointCode}");
        Console.WriteLine($"MelissaAddressKey: {record.MelissaAddressKey}");
        Console.WriteLine($"PostalCode: {record.PostalCode}");
        Console.WriteLine($"Results: {record.Results}");
        Console.WriteLine($"State: {record.State}");
        Console.WriteLine($"StateName: {record.StateName}");
      }
    }

    /// <summary>
    /// This asynchronous function uses the Smart Mover Cloud API object to make a GET request
    /// </summary>
    public async Task SmartMoverAsyncSample()
    {
      SmartMover smartMover = new SmartMover(licenseKey);
      smartMover.SetPafID(pafId);
      smartMover.SetCompany("Melissa");
      smartMover.SetFullName("Ray Melissa");
      smartMover.SetAddressLine1("22382 Avenida Empresa");
      smartMover.SetCity("Rancho Santa Margarita");
      smartMover.SetState("CA");
      smartMover.SetPostal("92688");
      smartMover.SetCountry("US");
      smartMover.SetCols("grpParsed");

      string response = await smartMover.GetAsync<string>();
      SmartMoverResponse responseObject = await smartMover.GetAsync<SmartMoverResponse>();

      Console.WriteLine(response);

      Console.WriteLine($"\nTotalRecords: {responseObject.TotalRecords}");
      Console.WriteLine($"TransmissionReference: {responseObject.TransmissionReference}");
      Console.WriteLine($"TransmissionResults: {responseObject.TransmissionResults}");
      Console.WriteLine($"Version: {responseObject.Version}");
      foreach (var record in responseObject.Records)
      {
        Console.WriteLine($"\nAddressHouseNumber: {record.AddressHouseNumber}");
        Console.WriteLine($"AddressKey: {record.AddressKey}");
        Console.WriteLine($"AddressLine1: {record.AddressLine1}");
        Console.WriteLine($"AddressStreetName: {record.AddressStreetName}");
        Console.WriteLine($"AddressTypeCode: {record.AddressTypeCode}");
        Console.WriteLine($"CarrierRoute: {record.CarrierRoute}");
        Console.WriteLine($"City: {record.City}");
        Console.WriteLine($"CityAbbreviation: {record.CityAbbreviation}");
        Console.WriteLine($"CompanyName: {record.CompanyName}");
        Console.WriteLine($"CountryCode: {record.CountryCode}");
        Console.WriteLine($"CountryName: {record.CountryName}");
        Console.WriteLine($"DeliveryIndicator: {record.DeliveryIndicator}");
        Console.WriteLine($"DeliveryPointCheckDigit: {record.DeliveryPointCheckDigit}");
        Console.WriteLine($"DeliveryPointCode: {record.DeliveryPointCode}");
        Console.WriteLine($"MelissaAddressKey: {record.MelissaAddressKey}");
        Console.WriteLine($"PostalCode: {record.PostalCode}");
        Console.WriteLine($"Results: {record.Results}");
        Console.WriteLine($"State: {record.State}");
        Console.WriteLine($"StateName: {record.StateName}");
      }
    }

    /// <summary>
    /// This function uses the Smart Mover Cloud API object to make a POST BATCH request
    /// This function showcases method 1 of setting and making POST requests: construct the POST body structure using the Cloud API's respective PostRequest class
    /// </summary>
    public void SmartMoverBatch1Sample()
    {
      SmartMover smartMover = new SmartMover();

      smartMover.SetPostBody(new SmartMoverPostRequest
      {
        CustomerID = licenseKey,
        PAFId = pafId,
        Records = new List<SmartMoverRecordRequest>
        {
          new SmartMoverRecordRequest
          {
            RecordID = "1",
            Company = "Melissa",
            NameFull = "Ray Melissa",
            AddressLine1 = "22382 Avenida Empresa",
            City = "Rancho Santa Margarita",
            State = "CA",
            PostalCode = "92688",
            Country = "US"
          },
          new SmartMoverRecordRequest
          {
            RecordID = "2",
            Company = "Melissa",
            NameFull = "John Melissa",
            AddressLine1 = "22382 Avenida Empresa",
            City = "Rancho Santa Margarita",
            State = "CA",
            PostalCode = "92688",
            Country = "US"
          }
        }
      });

      string response = smartMover.Post<string>();
      SmartMoverResponse responseObject = smartMover.Post<SmartMoverResponse>();

      Console.WriteLine(response);

      Console.WriteLine($"\nTotalRecords: {responseObject.TotalRecords}");
      Console.WriteLine($"TransmissionReference: {responseObject.TransmissionReference}");
      Console.WriteLine($"TransmissionResults: {responseObject.TransmissionResults}");
      Console.WriteLine($"Version: {responseObject.Version}");
      foreach (var record in responseObject.Records)
      {
        Console.WriteLine($"\nAddressHouseNumber: {record.AddressHouseNumber}");
        Console.WriteLine($"AddressKey: {record.AddressKey}");
        Console.WriteLine($"AddressLine1: {record.AddressLine1}");
        Console.WriteLine($"AddressStreetName: {record.AddressStreetName}");
        Console.WriteLine($"AddressTypeCode: {record.AddressTypeCode}");
        Console.WriteLine($"CarrierRoute: {record.CarrierRoute}");
        Console.WriteLine($"City: {record.City}");
        Console.WriteLine($"CityAbbreviation: {record.CityAbbreviation}");
        Console.WriteLine($"CompanyName: {record.CompanyName}");
        Console.WriteLine($"CountryCode: {record.CountryCode}");
        Console.WriteLine($"CountryName: {record.CountryName}");
        Console.WriteLine($"DeliveryIndicator: {record.DeliveryIndicator}");
        Console.WriteLine($"DeliveryPointCheckDigit: {record.DeliveryPointCheckDigit}");
        Console.WriteLine($"DeliveryPointCode: {record.DeliveryPointCode}");
        Console.WriteLine($"MelissaAddressKey: {record.MelissaAddressKey}");
        Console.WriteLine($"PostalCode: {record.PostalCode}");
        Console.WriteLine($"RecordID: {record.RecordID}");
        Console.WriteLine($"Results: {record.Results}");
        Console.WriteLine($"State: {record.State}");
        Console.WriteLine($"StateName: {record.StateName}");
      }
    }

    /// <summary>
    /// This function uses the Smart Mover Cloud API object to make a POST BATCH request
    /// This function showcases method 2 of setting and making POST requests: construct the POST body record by using the Cloud API's respective RecordRequest class
    /// </summary>
    public void SmartMoverBatch2Sample()
    {
      SmartMover smartMover = new SmartMover(licenseKey);
      smartMover.SetPafID(pafId);
      smartMover.AddRecord(new SmartMoverRecordRequest
      {
        RecordID = "1",
        Company = "Melissa",
        NameFull = "Ray Melissa",
        AddressLine1 = "22382 Avenida Empresa",
        City = "Rancho Santa Margarita",
        State = "CA",
        PostalCode = "92688",
        Country = "US"
      });
      smartMover.AddRecord(new SmartMoverRecordRequest
      {
        RecordID = "2",
        Company = "Melissa",
        NameFull = "John Melissa",
        AddressLine1 = "22382 Avenida Empresa",
        City = "Rancho Santa Margarita",
        State = "CA",
        PostalCode = "92688",
        Country = "US"
      });

      string response = smartMover.Post<string>();
      SmartMoverResponse responseObject = smartMover.Post<SmartMoverResponse>();

      Console.WriteLine(response);

      Console.WriteLine($"\nTotalRecords: {responseObject.TotalRecords}");
      Console.WriteLine($"TransmissionReference: {responseObject.TransmissionReference}");
      Console.WriteLine($"TransmissionResults: {responseObject.TransmissionResults}");
      Console.WriteLine($"Version: {responseObject.Version}");
      foreach (var record in responseObject.Records)
      {
        Console.WriteLine($"\nAddressHouseNumber: {record.AddressHouseNumber}");
        Console.WriteLine($"AddressKey: {record.AddressKey}");
        Console.WriteLine($"AddressLine1: {record.AddressLine1}");
        Console.WriteLine($"AddressStreetName: {record.AddressStreetName}");
        Console.WriteLine($"AddressTypeCode: {record.AddressTypeCode}");
        Console.WriteLine($"CarrierRoute: {record.CarrierRoute}");
        Console.WriteLine($"City: {record.City}");
        Console.WriteLine($"CityAbbreviation: {record.CityAbbreviation}");
        Console.WriteLine($"CompanyName: {record.CompanyName}");
        Console.WriteLine($"CountryCode: {record.CountryCode}");
        Console.WriteLine($"CountryName: {record.CountryName}");
        Console.WriteLine($"DeliveryIndicator: {record.DeliveryIndicator}");
        Console.WriteLine($"DeliveryPointCheckDigit: {record.DeliveryPointCheckDigit}");
        Console.WriteLine($"DeliveryPointCode: {record.DeliveryPointCode}");
        Console.WriteLine($"MelissaAddressKey: {record.MelissaAddressKey}");
        Console.WriteLine($"PostalCode: {record.PostalCode}");
        Console.WriteLine($"RecordID: {record.RecordID}");
        Console.WriteLine($"Results: {record.Results}");
        Console.WriteLine($"State: {record.State}");
        Console.WriteLine($"StateName: {record.StateName}");
      }
    }


    /// <summary>
    /// This asynchronous function uses the Smart Mover Cloud API object to make a POST BATCH request
    /// This function showcases method 1 of setting and making POST requests: construct the POST body structure using the Cloud API's respective PostRequest class
    /// </summary>
    public async Task SmartMoverBatchAsyncSample()
    {
      SmartMover smartMover = new SmartMover();

      smartMover.SetPostBody(new SmartMoverPostRequest
      {
        CustomerID = licenseKey,
        PAFId = pafId,
        Records = new List<SmartMoverRecordRequest>
        {
          new SmartMoverRecordRequest
          {
            RecordID = "1",
            Company = "Melissa",
            NameFull = "Ray Melissa",
            AddressLine1 = "22382 Avenida Empresa",
            City = "Rancho Santa Margarita",
            State = "CA",
            PostalCode = "92688",
            Country = "US"
          },
          new SmartMoverRecordRequest
          {
            RecordID = "2",
            Company = "Melissa",
            NameFull = "John Melissa",
            AddressLine1 = "22382 Avenida Empresa",
            City = "Rancho Santa Margarita",
            State = "CA",
            PostalCode = "92688",
            Country = "US"
          }
        }
      });

      string response = await smartMover.PostAsync<string>();
      SmartMoverResponse responseObject = await smartMover.PostAsync<SmartMoverResponse>();

      Console.WriteLine(response);

      Console.WriteLine($"\nTotalRecords: {responseObject.TotalRecords}");
      Console.WriteLine($"TransmissionReference: {responseObject.TransmissionReference}");
      Console.WriteLine($"TransmissionResults: {responseObject.TransmissionResults}");
      Console.WriteLine($"Version: {responseObject.Version}");
      foreach (var record in responseObject.Records)
      {
        Console.WriteLine($"\nAddressHouseNumber: {record.AddressHouseNumber}");
        Console.WriteLine($"AddressKey: {record.AddressKey}");
        Console.WriteLine($"AddressLine1: {record.AddressLine1}");
        Console.WriteLine($"AddressStreetName: {record.AddressStreetName}");
        Console.WriteLine($"AddressTypeCode: {record.AddressTypeCode}");
        Console.WriteLine($"CarrierRoute: {record.CarrierRoute}");
        Console.WriteLine($"City: {record.City}");
        Console.WriteLine($"CityAbbreviation: {record.CityAbbreviation}");
        Console.WriteLine($"CompanyName: {record.CompanyName}");
        Console.WriteLine($"CountryCode: {record.CountryCode}");
        Console.WriteLine($"CountryName: {record.CountryName}");
        Console.WriteLine($"DeliveryIndicator: {record.DeliveryIndicator}");
        Console.WriteLine($"DeliveryPointCheckDigit: {record.DeliveryPointCheckDigit}");
        Console.WriteLine($"DeliveryPointCode: {record.DeliveryPointCode}");
        Console.WriteLine($"MelissaAddressKey: {record.MelissaAddressKey}");
        Console.WriteLine($"PostalCode: {record.PostalCode}");
        Console.WriteLine($"RecordID: {record.RecordID}");
        Console.WriteLine($"Results: {record.Results}");
        Console.WriteLine($"State: {record.State}");
        Console.WriteLine($"StateName: {record.StateName}");
      }
    }

    public void SmartMoverSetValueSample()
    {
      SmartMover smartMover = new SmartMover(licenseKey);

      smartMover.SetValue("PAFId", pafId);
      smartMover.SetValue("Company", "Melissa");
      smartMover.SetValue("FullName", "Ray Melissa");
      smartMover.SetValue("AddressLine1", "22382 Avenida Empresa");
      smartMover.SetValue("City", "Rancho Santa Margarita");
      smartMover.SetValue("State", "CA");
      smartMover.SetValue("Postal", "92688");
      smartMover.SetValue("Country", "US");
      smartMover.SetValue("Cols", "grpParsed");

      string response = smartMover.Get<string>();
      SmartMoverResponse responseObject = smartMover.Get<SmartMoverResponse>();

      Console.WriteLine(response);

      Console.WriteLine($"\nTotalRecords: {responseObject.TotalRecords}");
      Console.WriteLine($"TransmissionReference: {responseObject.TransmissionReference}");
      Console.WriteLine($"TransmissionResults: {responseObject.TransmissionResults}");
      Console.WriteLine($"Version: {responseObject.Version}");
      foreach (var record in responseObject.Records)
      {
        Console.WriteLine($"\nAddressHouseNumber: {record.AddressHouseNumber}");
        Console.WriteLine($"AddressKey: {record.AddressKey}");
        Console.WriteLine($"AddressLine1: {record.AddressLine1}");
        Console.WriteLine($"AddressStreetName: {record.AddressStreetName}");
        Console.WriteLine($"AddressTypeCode: {record.AddressTypeCode}");
        Console.WriteLine($"CarrierRoute: {record.CarrierRoute}");
        Console.WriteLine($"City: {record.City}");
        Console.WriteLine($"CityAbbreviation: {record.CityAbbreviation}");
        Console.WriteLine($"CompanyName: {record.CompanyName}");
        Console.WriteLine($"CountryCode: {record.CountryCode}");
        Console.WriteLine($"CountryName: {record.CountryName}");
        Console.WriteLine($"DeliveryIndicator: {record.DeliveryIndicator}");
        Console.WriteLine($"DeliveryPointCheckDigit: {record.DeliveryPointCheckDigit}");
        Console.WriteLine($"DeliveryPointCode: {record.DeliveryPointCode}");
        Console.WriteLine($"MelissaAddressKey: {record.MelissaAddressKey}");
        Console.WriteLine($"PostalCode: {record.PostalCode}");
        Console.WriteLine($"Results: {record.Results}");
        Console.WriteLine($"State: {record.State}");
        Console.WriteLine($"StateName: {record.StateName}");
      }
    }

    public void SmartMoverSetValueSample2()
    {
      SmartMover smartMover = new SmartMover(licenseKey);

      smartMover.PafID = pafId;
      smartMover.Company = "Melissa";
      smartMover.FullName = "Ray Melissa";
      smartMover.AddressLine1 = "22382 Avenida Empresa";
      smartMover.City = "Rancho Santa Margarita";
      smartMover.State = "CA";
      smartMover.Postal = "92688";
      smartMover.Country = "US";
      smartMover.Cols = "grpParsed";

      string response = smartMover.Get<string>();
      SmartMoverResponse responseObject = smartMover.Get<SmartMoverResponse>();

      Console.WriteLine(response);

      Console.WriteLine($"\nTotalRecords: {responseObject.TotalRecords}");
      Console.WriteLine($"TransmissionReference: {responseObject.TransmissionReference}");
      Console.WriteLine($"TransmissionResults: {responseObject.TransmissionResults}");
      Console.WriteLine($"Version: {responseObject.Version}");
      foreach (var record in responseObject.Records)
      {
        Console.WriteLine($"\nAddressHouseNumber: {record.AddressHouseNumber}");
        Console.WriteLine($"AddressKey: {record.AddressKey}");
        Console.WriteLine($"AddressLine1: {record.AddressLine1}");
        Console.WriteLine($"AddressStreetName: {record.AddressStreetName}");
        Console.WriteLine($"AddressTypeCode: {record.AddressTypeCode}");
        Console.WriteLine($"CarrierRoute: {record.CarrierRoute}");
        Console.WriteLine($"City: {record.City}");
        Console.WriteLine($"CityAbbreviation: {record.CityAbbreviation}");
        Console.WriteLine($"CompanyName: {record.CompanyName}");
        Console.WriteLine($"CountryCode: {record.CountryCode}");
        Console.WriteLine($"CountryName: {record.CountryName}");
        Console.WriteLine($"DeliveryIndicator: {record.DeliveryIndicator}");
        Console.WriteLine($"DeliveryPointCheckDigit: {record.DeliveryPointCheckDigit}");
        Console.WriteLine($"DeliveryPointCode: {record.DeliveryPointCode}");
        Console.WriteLine($"MelissaAddressKey: {record.MelissaAddressKey}");
        Console.WriteLine($"PostalCode: {record.PostalCode}");
        Console.WriteLine($"Results: {record.Results}");
        Console.WriteLine($"State: {record.State}");
        Console.WriteLine($"StateName: {record.StateName}");
      }
    }
  }
}
