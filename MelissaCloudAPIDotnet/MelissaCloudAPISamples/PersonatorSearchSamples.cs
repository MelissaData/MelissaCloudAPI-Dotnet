using MelissaData.CloudAPI;

namespace MelissaCloudAPIDotnet.MelissaCloudAPISamples
{
  public class PersonatorSearchSamples
  {
    public string licenseKey;

    public PersonatorSearchSamples(string licenseKey)
    {
      this.licenseKey = licenseKey;
    }

    /// <summary>
    /// This function uses the Personator Search Cloud API object to make a GET request
    /// </summary>
    public void PersonatorSearchSample()
    {
      PersonatorSearch personator = new PersonatorSearch(licenseKey);
      personator.SetFullName("Raymond Melissa");
      personator.SetAddressLine1("22382 Avenida Empresa");
      personator.SetCity("RSM");
      personator.SetState("CA");
      personator.SetPostal("92688");
      personator.SetCols("GrpAll");

      string response = personator.Get<string>();
      PersonatorSearchResponse responseObject = personator.Get<PersonatorSearchResponse>();

      Console.WriteLine(response);

      Console.WriteLine($"\nTransmissionResults: {responseObject.TransmissionResults}");
      Console.WriteLine($"TransmissionReference: {responseObject.TransmissionReference}");
      Console.WriteLine($"TotalPages: {responseObject.TotalPages}");
      Console.WriteLine($"TotalRecords: {responseObject.TotalRecords}");
      Console.WriteLine($"Version: {responseObject.Version}");
      foreach (var record in responseObject.Records)
      {
        Console.WriteLine($"\nRecordID: {record.RecordID}");
        Console.WriteLine($"Results: {record.Results}");
        Console.WriteLine($"FullName: {record.FullName}");
        Console.WriteLine($"FirstName: {record.FirstName}");
        Console.WriteLine($"LastName: {record.LastName}");
        Console.WriteLine($"DateOfBirth: {record.DateOfBirth}");
        Console.WriteLine($"DateOfDeath: {record.DateOfDeath}");
        Console.WriteLine($"MelissaIdentityKey: {record.MelissaIdentityKey}");
        Console.WriteLine($"CurrentAddress:");
        Console.WriteLine($"\tAddressLine1: {record.CurrentAddress.AddressLine1}");
        Console.WriteLine($"\tCity: {record.CurrentAddress.City}");
        Console.WriteLine($"\tState: {record.CurrentAddress.State}");
        Console.WriteLine($"\tPostalCode: {record.CurrentAddress.PostalCode}");
        Console.WriteLine($"\tPlus4: {record.CurrentAddress.Plus4}");
        Console.WriteLine($"\tMelissaAddressKey: {record.CurrentAddress.MelissaAddressKey}");
      }
    }

    /// <summary>
    /// This asynchronous function uses the Personator Search Cloud API object to make a GET request
    /// </summary>
    public async Task PersonatorSearchAsyncSample()
    {
      PersonatorSearch personator = new PersonatorSearch(licenseKey);
      personator.SetFullName("Raymond Melissa");
      personator.SetAddressLine1("22382 Avenida Empresa");
      personator.SetCity("RSM");
      personator.SetState("CA");
      personator.SetPostal("92688");
      personator.SetCols("GrpAll");

      string response = await personator.GetAsync<string>();
      PersonatorSearchResponse responseObject = await personator.GetAsync<PersonatorSearchResponse>();

      Console.WriteLine(response);

      Console.WriteLine($"\nTransmissionResults: {responseObject.TransmissionResults}");
      Console.WriteLine($"TransmissionReference: {responseObject.TransmissionReference}");
      Console.WriteLine($"TotalPages: {responseObject.TotalPages}");
      Console.WriteLine($"TotalRecords: {responseObject.TotalRecords}");
      Console.WriteLine($"Version: {responseObject.Version}");
      foreach (var record in responseObject.Records)
      {
        Console.WriteLine($"\nRecordID: {record.RecordID}");
        Console.WriteLine($"Results: {record.Results}");
        Console.WriteLine($"FullName: {record.FullName}");
        Console.WriteLine($"FirstName: {record.FirstName}");
        Console.WriteLine($"LastName: {record.LastName}");
        Console.WriteLine($"DateOfBirth: {record.DateOfBirth}");
        Console.WriteLine($"DateOfDeath: {record.DateOfDeath}");
        Console.WriteLine($"MelissaIdentityKey: {record.MelissaIdentityKey}");
        Console.WriteLine($"CurrentAddress:");
        Console.WriteLine($"\tAddressLine1: {record.CurrentAddress.AddressLine1}");
        Console.WriteLine($"\tCity: {record.CurrentAddress.City}");
        Console.WriteLine($"\tState: {record.CurrentAddress.State}");
        Console.WriteLine($"\tPostalCode: {record.CurrentAddress.PostalCode}");
        Console.WriteLine($"\tPlus4: {record.CurrentAddress.Plus4}");
        Console.WriteLine($"\tMelissaAddressKey: {record.CurrentAddress.MelissaAddressKey}");
      }
    }

    public void PersonatorSearchSetValueSample()
    {
      PersonatorSearch personator = new PersonatorSearch(licenseKey);

      personator.SetValue("FullName", "Raymond Melissa");
      personator.SetValue("AddressLine1", "22382 Avenida Empresa");
      personator.SetValue("City", "RSM");
      personator.SetValue("State", "CA");
      personator.SetValue("Postal", "92688");
      personator.SetValue("Cols", "GrpAll");

      string response = personator.Get<string>();
      PersonatorSearchResponse responseObject = personator.Get<PersonatorSearchResponse>();

      Console.WriteLine(response);

      Console.WriteLine($"\nTransmissionResults: {responseObject.TransmissionResults}");
      Console.WriteLine($"TransmissionReference: {responseObject.TransmissionReference}");
      Console.WriteLine($"TotalPages: {responseObject.TotalPages}");
      Console.WriteLine($"TotalRecords: {responseObject.TotalRecords}");
      Console.WriteLine($"Version: {responseObject.Version}");
      foreach (var record in responseObject.Records)
      {
        Console.WriteLine($"\nRecordID: {record.RecordID}");
        Console.WriteLine($"Results: {record.Results}");
        Console.WriteLine($"FullName: {record.FullName}");
        Console.WriteLine($"FirstName: {record.FirstName}");
        Console.WriteLine($"LastName: {record.LastName}");
        Console.WriteLine($"DateOfBirth: {record.DateOfBirth}");
        Console.WriteLine($"DateOfDeath: {record.DateOfDeath}");
        Console.WriteLine($"MelissaIdentityKey: {record.MelissaIdentityKey}");
        Console.WriteLine($"CurrentAddress:");
        Console.WriteLine($"\tAddressLine1: {record.CurrentAddress.AddressLine1}");
        Console.WriteLine($"\tCity: {record.CurrentAddress.City}");
        Console.WriteLine($"\tState: {record.CurrentAddress.State}");
        Console.WriteLine($"\tPostalCode: {record.CurrentAddress.PostalCode}");
        Console.WriteLine($"\tPlus4: {record.CurrentAddress.Plus4}");
        Console.WriteLine($"\tMelissaAddressKey: {record.CurrentAddress.MelissaAddressKey}");
      }
    }

    public void PersonatorSearchSetValueSample2()
    {
      PersonatorSearch personator = new PersonatorSearch(licenseKey);

      personator.FullName = "Raymond Melissa";
      personator.AddressLine1 = "22382 Avenida Empresa";
      personator.City = "RSM";
      personator.State = "CA";
      personator.Postal = "92688";
      personator.Cols = "GrpAll";

      string response = personator.Get<string>();
      PersonatorSearchResponse responseObject = personator.Get<PersonatorSearchResponse>();

      Console.WriteLine(response);

      Console.WriteLine($"\nTransmissionResults: {responseObject.TransmissionResults}");
      Console.WriteLine($"TransmissionReference: {responseObject.TransmissionReference}");
      Console.WriteLine($"TotalPages: {responseObject.TotalPages}");
      Console.WriteLine($"TotalRecords: {responseObject.TotalRecords}");
      Console.WriteLine($"Version: {responseObject.Version}");
      foreach (var record in responseObject.Records)
      {
        Console.WriteLine($"\nRecordID: {record.RecordID}");
        Console.WriteLine($"Results: {record.Results}");
        Console.WriteLine($"FullName: {record.FullName}");
        Console.WriteLine($"FirstName: {record.FirstName}");
        Console.WriteLine($"LastName: {record.LastName}");
        Console.WriteLine($"DateOfBirth: {record.DateOfBirth}");
        Console.WriteLine($"DateOfDeath: {record.DateOfDeath}");
        Console.WriteLine($"MelissaIdentityKey: {record.MelissaIdentityKey}");
        Console.WriteLine($"CurrentAddress:");
        Console.WriteLine($"\tAddressLine1: {record.CurrentAddress.AddressLine1}");
        Console.WriteLine($"\tCity: {record.CurrentAddress.City}");
        Console.WriteLine($"\tState: {record.CurrentAddress.State}");
        Console.WriteLine($"\tPostalCode: {record.CurrentAddress.PostalCode}");
        Console.WriteLine($"\tPlus4: {record.CurrentAddress.Plus4}");
        Console.WriteLine($"\tMelissaAddressKey: {record.CurrentAddress.MelissaAddressKey}");
      }
    }
  }
}
