using MelissaData.CloudAPI;

namespace MelissaCloudAPIDotnet.MelissaCloudAPISamples
{
  public class PersonatorConsumerSamples
  {
    public string licenseKey;

    public PersonatorConsumerSamples(string licenseKey)
    {
      this.licenseKey = licenseKey;
    }

    /// <summary>
    /// This function uses the Personator Consumer Cloud API object to make a GET request
    /// </summary>
    public void PersonatorConsumerSample()
    {
      PersonatorConsumer personator = new PersonatorConsumer(licenseKey);
      personator.SetFullName("Ray Melissa");
      personator.SetAddressLine1("22382 Avenida Empresa");
      personator.SetCity("Rancho Santa Margarita");
      personator.SetState("CA");
      personator.SetPostal("92688");
      personator.SetCountry("United States");
      personator.SetEmail("info@melissa.com");
      personator.SetPhone("800-635-4772");

      string response = personator.Get<string>();
      PersonatorConsumerResponse responseObject = personator.Get<PersonatorConsumerResponse>();

      Console.WriteLine(response);

      Console.WriteLine($"\nVersion: {responseObject.Version}");
      Console.WriteLine($"TransmissionReference: {responseObject.TransmissionReference}");
      Console.WriteLine($"TransmissionResults: {responseObject.TransmissionResults}");
      Console.WriteLine($"TotalRecords: {responseObject.TotalRecords}\n");
      foreach (var record in responseObject.Records)
      {
        Console.WriteLine("AddressExtras: " + record.RecordID);
        Console.WriteLine("AddressKey: " + record.AddressKey);
        Console.WriteLine("AddressLine1: " + record.AddressLine1);
        Console.WriteLine("AddressLine2: " + record.AddressLine2);
        Console.WriteLine("City: " + record.City);
        Console.WriteLine("CompanyName: " + record.CompanyName);
        Console.WriteLine("EmailAddress: " + record.EmailAddress);
        Console.WriteLine("MelissaAddressKey: " + record.MelissaAddressKey);
        Console.WriteLine("MelissaAddressKeyBase: " + record.MelissaAddressKeyBase);
        Console.WriteLine("NameFull: " + record.NameFull);
        Console.WriteLine("PhoneNumber: " + record.PhoneNumber);
        Console.WriteLine("PostalCode: " + record.PostalCode);
        Console.WriteLine("RecordExtras: " + record.RecordExtras);
        Console.WriteLine("RecordID: " + record.RecordID);
        Console.WriteLine("Reserved: " + record.Reserved);
        Console.WriteLine("Results: " + record.Results);
        Console.WriteLine("State: " + record.State);
      }
    }

    /// <summary>
    /// This asynchronous function uses the Global Address Verification Cloud API object to make a GET request
    /// </summary>
    public async Task PersonatorConsumerAsyncSample()
    {
      PersonatorConsumer personator = new PersonatorConsumer(licenseKey);
      personator.SetFullName("Ray Melissa");
      personator.SetAddressLine1("22382 Avenida Empresa");
      personator.SetCity("Rancho Santa Margarita");
      personator.SetState("CA");
      personator.SetPostal("92688");
      personator.SetCountry("United States");
      personator.SetEmail("info@melissa.com");
      personator.SetPhone("800-635-4772");

      string response = await personator.GetAsync<string>();
      PersonatorConsumerResponse responseObject = await personator.GetAsync<PersonatorConsumerResponse>();

      Console.WriteLine(response);

      Console.WriteLine($"\nVersion: {responseObject.Version}");
      Console.WriteLine($"TransmissionReference: {responseObject.TransmissionReference}");
      Console.WriteLine($"TransmissionResults: {responseObject.TransmissionResults}");
      Console.WriteLine($"TotalRecords: {responseObject.TotalRecords}\n");
      foreach (var record in responseObject.Records)
      {
        Console.WriteLine("AddressExtras: " + record.RecordID);
        Console.WriteLine("AddressKey: " + record.AddressKey);
        Console.WriteLine("AddressLine1: " + record.AddressLine1);
        Console.WriteLine("AddressLine2: " + record.AddressLine2);
        Console.WriteLine("City: " + record.City);
        Console.WriteLine("CompanyName: " + record.CompanyName);
        Console.WriteLine("EmailAddress: " + record.EmailAddress);
        Console.WriteLine("MelissaAddressKey: " + record.MelissaAddressKey);
        Console.WriteLine("MelissaAddressKeyBase: " + record.MelissaAddressKeyBase);
        Console.WriteLine("NameFull: " + record.NameFull);
        Console.WriteLine("PhoneNumber: " + record.PhoneNumber);
        Console.WriteLine("PostalCode: " + record.PostalCode);
        Console.WriteLine("RecordExtras: " + record.RecordExtras);
        Console.WriteLine("RecordID: " + record.RecordID);
        Console.WriteLine("Reserved: " + record.Reserved);
        Console.WriteLine("Results: " + record.Results);
        Console.WriteLine("State: " + record.State);
      }
    }

    /// <summary>
    /// This function uses the Personator Consumer Cloud API object to make a POST BATCH request
    /// This function showcases method 1 of setting and making POST requests: construct the POST body structure using the Cloud API's respective PostRequest class
    /// </summary>
    public void PersonatorConsumerBatch1Sample()
    {
      PersonatorConsumer personatorConsumer = new PersonatorConsumer();
      personatorConsumer.SetPostBody(new PersonatorConsumerPostRequest
      {
        CustomerID = licenseKey,
        Records = new List<PersonatorConsumerRecordRequest>
        {
          new PersonatorConsumerRecordRequest
          {
            RecordID = "1",
            FullName = "Raymond Melissa",
            AddressLine1 = "22382 Avenida Empresa",
            City = "Rancho Santa Margarita",
            State = "CA",
            PostalCode = "92688"
          },
          new PersonatorConsumerRecordRequest
          {
             RecordID = "2",
             FullName = "John Melissa",
             AddressLine1 = "22382 Avenida Empresa",
             City = "Rancho Santa Margarita",
             State = "CA",
             PostalCode = "92688"
          }
        }
      });

      string response = personatorConsumer.Post<string>();
      PersonatorConsumerResponse responseObject = personatorConsumer.Post<PersonatorConsumerResponse>();

      Console.WriteLine(response);

      Console.WriteLine($"\nVersion: {responseObject.Version}");
      Console.WriteLine($"TransmissionReference: {responseObject.TransmissionReference}");
      Console.WriteLine($"TransmissionResults: {responseObject.TransmissionResults}");
      Console.WriteLine($"TotalRecords: {responseObject.TotalRecords}\n");
      foreach (var record in responseObject.Records)
      {
        Console.WriteLine("AddressExtras: " + record.RecordID);
        Console.WriteLine("AddressKey: " + record.AddressKey);
        Console.WriteLine("AddressLine1: " + record.AddressLine1);
        Console.WriteLine("AddressLine2: " + record.AddressLine2);
        Console.WriteLine("City: " + record.City);
        Console.WriteLine("CompanyName: " + record.CompanyName);
        Console.WriteLine("EmailAddress: " + record.EmailAddress);
        Console.WriteLine("MelissaAddressKey: " + record.MelissaAddressKey);
        Console.WriteLine("MelissaAddressKeyBase: " + record.MelissaAddressKeyBase);
        Console.WriteLine("NameFull: " + record.NameFull);
        Console.WriteLine("PhoneNumber: " + record.PhoneNumber);
        Console.WriteLine("PostalCode: " + record.PostalCode);
        Console.WriteLine("RecordExtras: " + record.RecordExtras);
        Console.WriteLine("RecordID: " + record.RecordID);
        Console.WriteLine("Reserved: " + record.Reserved);
        Console.WriteLine("Results: " + record.Results);
        Console.WriteLine("State: " + record.State + "\n\n");
      }
    }

    /// <summary>
    /// This function uses the Personator Consumer Cloud API object to make a POST BATCH request
    /// This function showcases method 2 of setting and making POST requests: construct the POST body record by using the Cloud API's respective RecordRequest class
    /// </summary>
    public void PersonatorConsumerBatch2Sample()
    {
      PersonatorConsumer personatorConsumer = new PersonatorConsumer(licenseKey);
      personatorConsumer.AddRecord(
        new PersonatorConsumerRecordRequest
        {
          RecordID = "1",
          FullName = "Raymond Melissa",
          AddressLine1 = "22382 Avenida Empresa",
          City = "Rancho Santa Margarita",
          State = "CA",
          PostalCode = "92688"
        });
      personatorConsumer.AddRecord(
        new PersonatorConsumerRecordRequest
        {
          RecordID = "2",
          FullName = "John Melissa",
          AddressLine1 = "22382 Avenida Empresa",
          City = "Rancho Santa Margarita",
          State = "CA",
          PostalCode = "92688"
        });

      string response = personatorConsumer.Post<string>();
      PersonatorConsumerResponse responseObject = personatorConsumer.Post<PersonatorConsumerResponse>();

      Console.WriteLine(response);

      Console.WriteLine($"\nVersion: {responseObject.Version}");
      Console.WriteLine($"TransmissionReference: {responseObject.TransmissionReference}");
      Console.WriteLine($"TransmissionResults: {responseObject.TransmissionResults}");
      Console.WriteLine($"TotalRecords: {responseObject.TotalRecords}\n");
      foreach (var record in responseObject.Records)
      {
        Console.WriteLine("AddressExtras: " + record.RecordID);
        Console.WriteLine("AddressKey: " + record.AddressKey);
        Console.WriteLine("AddressLine1: " + record.AddressLine1);
        Console.WriteLine("AddressLine2: " + record.AddressLine2);
        Console.WriteLine("City: " + record.City);
        Console.WriteLine("CompanyName: " + record.CompanyName);
        Console.WriteLine("EmailAddress: " + record.EmailAddress);
        Console.WriteLine("MelissaAddressKey: " + record.MelissaAddressKey);
        Console.WriteLine("MelissaAddressKeyBase: " + record.MelissaAddressKeyBase);
        Console.WriteLine("NameFull: " + record.NameFull);
        Console.WriteLine("PhoneNumber: " + record.PhoneNumber);
        Console.WriteLine("PostalCode: " + record.PostalCode);
        Console.WriteLine("RecordExtras: " + record.RecordExtras);
        Console.WriteLine("RecordID: " + record.RecordID);
        Console.WriteLine("Reserved: " + record.Reserved);
        Console.WriteLine("Results: " + record.Results);
        Console.WriteLine("State: " + record.State + "\n\n");
      }
    }

    /// <summary>
    /// This asynchronous function uses the Personator Consumer Cloud API object to make a POST request
    /// </summary>
    public async Task PersonatorConsumerBatchAsyncSample()
    {
      PersonatorConsumer personatorConsumer = new PersonatorConsumer();
      personatorConsumer.SetPostBody(new PersonatorConsumerPostRequest
      {
        CustomerID = licenseKey,
        Records = new List<PersonatorConsumerRecordRequest>
        {
          new PersonatorConsumerRecordRequest
          {
            RecordID = "1",
            FullName = "Raymond Melissa",
            AddressLine1 = "22382 Avenida Empresa",
            City = "Rancho Santa Margarita",
            State = "CA",
            PostalCode = "92688"
          },
          new PersonatorConsumerRecordRequest
          {
            RecordID = "2",
            FullName = "John Melissa",
            AddressLine1 = "22382 Avenida Empresa",
            City = "Rancho Santa Margarita",
            State = "CA",
            PostalCode = "92688"
          }
        }
      });

      string response = await personatorConsumer.PostAsync<string>();
      PersonatorConsumerResponse responseObject = await personatorConsumer.PostAsync<PersonatorConsumerResponse>();

      Console.WriteLine(response);

      Console.WriteLine($"\nVersion: {responseObject.Version}");
      Console.WriteLine($"TransmissionReference: {responseObject.TransmissionReference}");
      Console.WriteLine($"TransmissionResults: {responseObject.TransmissionResults}");
      Console.WriteLine($"TotalRecords: {responseObject.TotalRecords}\n");
      foreach (var record in responseObject.Records)
      {
        Console.WriteLine("AddressExtras: " + record.RecordID);
        Console.WriteLine("AddressKey: " + record.AddressKey);
        Console.WriteLine("AddressLine1: " + record.AddressLine1);
        Console.WriteLine("AddressLine2: " + record.AddressLine2);
        Console.WriteLine("City: " + record.City);
        Console.WriteLine("CompanyName: " + record.CompanyName);
        Console.WriteLine("EmailAddress: " + record.EmailAddress);
        Console.WriteLine("MelissaAddressKey: " + record.MelissaAddressKey);
        Console.WriteLine("MelissaAddressKeyBase: " + record.MelissaAddressKeyBase);
        Console.WriteLine("NameFull: " + record.NameFull);
        Console.WriteLine("PhoneNumber: " + record.PhoneNumber);
        Console.WriteLine("PostalCode: " + record.PostalCode);
        Console.WriteLine("RecordExtras: " + record.RecordExtras);
        Console.WriteLine("RecordID: " + record.RecordID);
        Console.WriteLine("Reserved: " + record.Reserved);
        Console.WriteLine("Results: " + record.Results);
        Console.WriteLine("State: " + record.State + "\n\n");
      }
    }

    public void PersonatorConsumerSetValueSample()
    {
      PersonatorConsumer personator = new PersonatorConsumer(licenseKey);

      personator.SetValue("FullName", "Ray Melissa");
      personator.SetValue("AddressLine1", "22382 Avenida Empresa");
      personator.SetValue("City", "Rancho Santa Margarita");
      personator.SetValue("State", "CA");
      personator.SetValue("Postal", "92688");
      personator.SetValue("Country", "United States");
      personator.SetValue("Email", "info@melissa.com");
      personator.SetValue("Phone", "800-635-4772");

      string response = personator.Get<string>();
      PersonatorConsumerResponse responseObject = personator.Get<PersonatorConsumerResponse>();

      Console.WriteLine(response);

      Console.WriteLine($"\nVersion: {responseObject.Version}");
      Console.WriteLine($"TransmissionReference: {responseObject.TransmissionReference}");
      Console.WriteLine($"TransmissionResults: {responseObject.TransmissionResults}");
      Console.WriteLine($"TotalRecords: {responseObject.TotalRecords}\n");
      foreach (var record in responseObject.Records)
      {
        Console.WriteLine("AddressExtras: " + record.RecordID);
        Console.WriteLine("AddressKey: " + record.AddressKey);
        Console.WriteLine("AddressLine1: " + record.AddressLine1);
        Console.WriteLine("AddressLine2: " + record.AddressLine2);
        Console.WriteLine("City: " + record.City);
        Console.WriteLine("CompanyName: " + record.CompanyName);
        Console.WriteLine("EmailAddress: " + record.EmailAddress);
        Console.WriteLine("MelissaAddressKey: " + record.MelissaAddressKey);
        Console.WriteLine("MelissaAddressKeyBase: " + record.MelissaAddressKeyBase);
        Console.WriteLine("NameFull: " + record.NameFull);
        Console.WriteLine("PhoneNumber: " + record.PhoneNumber);
        Console.WriteLine("PostalCode: " + record.PostalCode);
        Console.WriteLine("RecordExtras: " + record.RecordExtras);
        Console.WriteLine("RecordID: " + record.RecordID);
        Console.WriteLine("Reserved: " + record.Reserved);
        Console.WriteLine("Results: " + record.Results);
        Console.WriteLine("State: " + record.State);
      }
    }

    public void PersonatorConsumerSetValueSample2()
    {
      PersonatorConsumer personator = new PersonatorConsumer(licenseKey);

      personator.FullName = "Ray Melissa";
      personator.AddressLine1 = "22382 Avenida Empresa";
      personator.City = "Rancho Santa Margarita";
      personator.State = "CA";
      personator.Postal = "92688";
      personator.Country = "United States";
      personator.Email = "info@melissa.com";
      personator.Phone = "800-635-4772";

      string response = personator.Get<string>();
      PersonatorConsumerResponse responseObject = personator.Get<PersonatorConsumerResponse>();

      Console.WriteLine(response);

      Console.WriteLine($"\nVersion: {responseObject.Version}");
      Console.WriteLine($"TransmissionReference: {responseObject.TransmissionReference}");
      Console.WriteLine($"TransmissionResults: {responseObject.TransmissionResults}");
      Console.WriteLine($"TotalRecords: {responseObject.TotalRecords}\n");
      foreach (var record in responseObject.Records)
      {
        Console.WriteLine("AddressExtras: " + record.RecordID);
        Console.WriteLine("AddressKey: " + record.AddressKey);
        Console.WriteLine("AddressLine1: " + record.AddressLine1);
        Console.WriteLine("AddressLine2: " + record.AddressLine2);
        Console.WriteLine("City: " + record.City);
        Console.WriteLine("CompanyName: " + record.CompanyName);
        Console.WriteLine("EmailAddress: " + record.EmailAddress);
        Console.WriteLine("MelissaAddressKey: " + record.MelissaAddressKey);
        Console.WriteLine("MelissaAddressKeyBase: " + record.MelissaAddressKeyBase);
        Console.WriteLine("NameFull: " + record.NameFull);
        Console.WriteLine("PhoneNumber: " + record.PhoneNumber);
        Console.WriteLine("PostalCode: " + record.PostalCode);
        Console.WriteLine("RecordExtras: " + record.RecordExtras);
        Console.WriteLine("RecordID: " + record.RecordID);
        Console.WriteLine("Reserved: " + record.Reserved);
        Console.WriteLine("Results: " + record.Results);
        Console.WriteLine("State: " + record.State);
      }
    }
  }
}
