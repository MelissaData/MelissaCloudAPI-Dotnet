using MelissaData.CloudAPI;

namespace MelissaCloudAPIDotnet.MelissaCloudAPISamples
{
  public class GlobalNameSamples
  {
    public string licenseKey;

    public GlobalNameSamples(string licenseKey) 
    {
      this.licenseKey = licenseKey;
    }

    /// <summary>
    /// This function uses the Global Name Cloud API object to make a GET request
    /// </summary>
    public void GlobalNameSample()
    {
      GlobalName globalName = new GlobalName(licenseKey);
      globalName.SetFullName("Raymond Melissa");

      string response = globalName.Get<string>();
      GlobalNameResponse responseObject = globalName.Get<GlobalNameResponse>();

      Console.WriteLine(response);

      Console.WriteLine($"\nVersion: {responseObject.Version}");
      Console.WriteLine($"TransmissionReference: {responseObject.TransmissionReference}");
      Console.WriteLine($"TransmissionResults: {responseObject.TransmissionResults}");
      Console.WriteLine($"TotalRecords: {responseObject.TotalRecords}\n");
      foreach (var record in responseObject.Records)
      {
        Console.WriteLine("RecordID: " + record.RecordID);
        Console.WriteLine("Results: " + record.Results);
        Console.WriteLine("Company: " + record.Company);
        Console.WriteLine("NamePrefix: " + record.NamePrefix);
        Console.WriteLine("NameFirst: " + record.NameFirst);
        Console.WriteLine("NameMiddle: " + record.NameMiddle);
        Console.WriteLine("NameLast: " + record.NameLast);
        Console.WriteLine("NameSuffix: " + record.NameSuffix);
        Console.WriteLine("NameNickname: " + record.NameNickname);
        Console.WriteLine("NameProfTitle: " + record.NameProfTitle);
        Console.WriteLine("Gender: " + record.Gender);
        Console.WriteLine("NamePrefix2: " + record.NamePrefix2);
        Console.WriteLine("NameFirst2: " + record.NameFirst2);
        Console.WriteLine("NameMiddle2: " + record.NameMiddle2);
        Console.WriteLine("NameLast2: " + record.NameLast2);
        Console.WriteLine("NameSuffix2: " + record.NameSuffix2);
        Console.WriteLine("NameNickname2: " + record.NameNickname2);
        Console.WriteLine("NameProfTitle2: " + record.NameProfTitle2);
        Console.WriteLine("Gender2: " + record.Gender2);
        Console.WriteLine("Salutation: " + record.Salutation);
        Console.WriteLine("Extras: " + record.Extras);
      }
    }

    /// <summary>
    /// This asynchronous function uses the Global Name Cloud API object to make a GET request
    /// </summary>
    public async Task GlobalNameAsyncSample()
    {
      GlobalName globalName = new GlobalName(licenseKey);
      globalName.SetFullName("Raymond Melissa");

      string response = await globalName.GetAsync<string>();
      GlobalNameResponse responseObject = await globalName.GetAsync<GlobalNameResponse>();

      Console.WriteLine(response);

      Console.WriteLine($"\nVersion: {responseObject.Version}");
      Console.WriteLine($"TransmissionReference: {responseObject.TransmissionReference}");
      Console.WriteLine($"TransmissionResults: {responseObject.TransmissionResults}");
      Console.WriteLine($"TotalRecords: {responseObject.TotalRecords}\n");
      foreach (var record in responseObject.Records)
      {
        Console.WriteLine("RecordID: " + record.RecordID);
        Console.WriteLine("Results: " + record.Results);
        Console.WriteLine("Company: " + record.Company);
        Console.WriteLine("NamePrefix: " + record.NamePrefix);
        Console.WriteLine("NameFirst: " + record.NameFirst);
        Console.WriteLine("NameMiddle: " + record.NameMiddle);
        Console.WriteLine("NameLast: " + record.NameLast);
        Console.WriteLine("NameSuffix: " + record.NameSuffix);
        Console.WriteLine("NameNickname: " + record.NameNickname);
        Console.WriteLine("NameProfTitle: " + record.NameProfTitle);
        Console.WriteLine("Gender: " + record.Gender);
        Console.WriteLine("NamePrefix2: " + record.NamePrefix2);
        Console.WriteLine("NameFirst2: " + record.NameFirst2);
        Console.WriteLine("NameMiddle2: " + record.NameMiddle2);
        Console.WriteLine("NameLast2: " + record.NameLast2);
        Console.WriteLine("NameSuffix2: " + record.NameSuffix2);
        Console.WriteLine("NameNickname2: " + record.NameNickname2);
        Console.WriteLine("NameProfTitle2: " + record.NameProfTitle2);
        Console.WriteLine("Gender2: " + record.Gender2);
        Console.WriteLine("Salutation: " + record.Salutation);
        Console.WriteLine("Extras: " + record.Extras);
      }
    }

    /// <summary>
    /// This function uses the Global Name Cloud API object to make a POST BATCH request
    /// This function showcases method 1 of setting and making POST requests: construct the POST body structure using the Cloud API's respective PostRequest class
    /// </summary>
    public void GlobalNameBatch1Sample()
    {
      GlobalName globalName = new GlobalName();
      globalName.SetPostBody(new GlobalNamePostRequest
      {
        CustomerID = licenseKey,
        Records = new List<GlobalNameRecordRequest>
        {
          new GlobalNameRecordRequest { RecordID = "1", FullName = "Raymond Melissa" },
          new GlobalNameRecordRequest { RecordID = "2", FullName = "Daniel Kha Le" }
        }
      });

      string response = globalName.Post<string>();
      GlobalNameResponse responseObject = globalName.Post<GlobalNameResponse>();

      Console.WriteLine(response);

      Console.WriteLine($"\nVersion: {responseObject.Version}");
      Console.WriteLine($"TransmissionReference: {responseObject.TransmissionReference}");
      Console.WriteLine($"TransmissionResults: {responseObject.TransmissionResults}");
      Console.WriteLine($"TotalRecords: {responseObject.TotalRecords}\n");
      foreach (var record in responseObject.Records)
      {
        Console.WriteLine("RecordID: " + record.RecordID);
        Console.WriteLine("Results: " + record.Results);
        Console.WriteLine("Company: " + record.Company);
        Console.WriteLine("NamePrefix: " + record.NamePrefix);
        Console.WriteLine("NameFirst: " + record.NameFirst);
        Console.WriteLine("NameMiddle: " + record.NameMiddle);
        Console.WriteLine("NameLast: " + record.NameLast);
        Console.WriteLine("NameSuffix: " + record.NameSuffix);
        Console.WriteLine("NameNickname: " + record.NameNickname);
        Console.WriteLine("NameProfTitle: " + record.NameProfTitle);
        Console.WriteLine("Gender: " + record.Gender);
        Console.WriteLine("NamePrefix2: " + record.NamePrefix2);
        Console.WriteLine("NameFirst2: " + record.NameFirst2);
        Console.WriteLine("NameMiddle2: " + record.NameMiddle2);
        Console.WriteLine("NameLast2: " + record.NameLast2);
        Console.WriteLine("NameSuffix2: " + record.NameSuffix2);
        Console.WriteLine("NameNickname2: " + record.NameNickname2);
        Console.WriteLine("NameProfTitle2: " + record.NameProfTitle2);
        Console.WriteLine("Gender2: " + record.Gender2);
        Console.WriteLine("Salutation: " + record.Salutation);
        Console.WriteLine("Extras: " + record.Extras + "\n\n");
      }
    }

    /// <summary>
    /// This function uses the Global Name Cloud API object to make a POST BATCH request
    /// This function showcases method 2 of setting and making POST requests: construct the POST body record by using the Cloud API's respective RecordRequest class
    /// </summary>
    public void GlobalNameBatch2Sample()
    {
      GlobalName globalName = new GlobalName(licenseKey);
      globalName.AddRecord(new GlobalNameRecordRequest { RecordID = "1", FullName = "Raymond Melissa" });
      globalName.AddRecord(new GlobalNameRecordRequest { RecordID = "2", FullName = "Daniel Kha Le" });

      string response = globalName.Post<string>();
      GlobalNameResponse responseObject = globalName.Post<GlobalNameResponse>();

      Console.WriteLine(response);

      Console.WriteLine($"\nVersion: {responseObject.Version}");
      Console.WriteLine($"TransmissionReference: {responseObject.TransmissionReference}");
      Console.WriteLine($"TransmissionResults: {responseObject.TransmissionResults}");
      Console.WriteLine($"TotalRecords: {responseObject.TotalRecords}\n");
      foreach (var record in responseObject.Records)
      {
        Console.WriteLine("RecordID: " + record.RecordID);
        Console.WriteLine("Results: " + record.Results);
        Console.WriteLine("Company: " + record.Company);
        Console.WriteLine("NamePrefix: " + record.NamePrefix);
        Console.WriteLine("NameFirst: " + record.NameFirst);
        Console.WriteLine("NameMiddle: " + record.NameMiddle);
        Console.WriteLine("NameLast: " + record.NameLast);
        Console.WriteLine("NameSuffix: " + record.NameSuffix);
        Console.WriteLine("NameNickname: " + record.NameNickname);
        Console.WriteLine("NameProfTitle: " + record.NameProfTitle);
        Console.WriteLine("Gender: " + record.Gender);
        Console.WriteLine("NamePrefix2: " + record.NamePrefix2);
        Console.WriteLine("NameFirst2: " + record.NameFirst2);
        Console.WriteLine("NameMiddle2: " + record.NameMiddle2);
        Console.WriteLine("NameLast2: " + record.NameLast2);
        Console.WriteLine("NameSuffix2: " + record.NameSuffix2);
        Console.WriteLine("NameNickname2: " + record.NameNickname2);
        Console.WriteLine("NameProfTitle2: " + record.NameProfTitle2);
        Console.WriteLine("Gender2: " + record.Gender2);
        Console.WriteLine("Salutation: " + record.Salutation);
        Console.WriteLine("Extras: " + record.Extras + "\n\n");
      }
    }

    /// <summary>
    /// This asynchronous function uses the Global Address Verification Cloud API object to make a POST request
    /// </summary>
    public async Task GlobalNameBatchAsyncSample()
    {
      GlobalName globalName = new GlobalName();
      globalName.SetPostBody(new GlobalNamePostRequest
      {
        CustomerID = licenseKey,
        Records = new List<GlobalNameRecordRequest>
        {
          new GlobalNameRecordRequest { RecordID = "1", FullName = "Raymond Melissa" },
          new GlobalNameRecordRequest { RecordID = "2", FullName = "Daniel Kha Le" }
        }
      });

      string response = await globalName.PostAsync<string>();
      GlobalNameResponse responseObject = await globalName.PostAsync<GlobalNameResponse>();

      Console.WriteLine(response);

      Console.WriteLine($"\nVersion: {responseObject.Version}");
      Console.WriteLine($"TransmissionReference: {responseObject.TransmissionReference}");
      Console.WriteLine($"TransmissionResults: {responseObject.TransmissionResults}");
      Console.WriteLine($"TotalRecords: {responseObject.TotalRecords}\n");
      foreach (var record in responseObject.Records)
      {
        Console.WriteLine("RecordID: " + record.RecordID);
        Console.WriteLine("Results: " + record.Results);
        Console.WriteLine("Company: " + record.Company);
        Console.WriteLine("NamePrefix: " + record.NamePrefix);
        Console.WriteLine("NameFirst: " + record.NameFirst);
        Console.WriteLine("NameMiddle: " + record.NameMiddle);
        Console.WriteLine("NameLast: " + record.NameLast);
        Console.WriteLine("NameSuffix: " + record.NameSuffix);
        Console.WriteLine("NameNickname: " + record.NameNickname);
        Console.WriteLine("NameProfTitle: " + record.NameProfTitle);
        Console.WriteLine("Gender: " + record.Gender);
        Console.WriteLine("NamePrefix2: " + record.NamePrefix2);
        Console.WriteLine("NameFirst2: " + record.NameFirst2);
        Console.WriteLine("NameMiddle2: " + record.NameMiddle2);
        Console.WriteLine("NameLast2: " + record.NameLast2);
        Console.WriteLine("NameSuffix2: " + record.NameSuffix2);
        Console.WriteLine("NameNickname2: " + record.NameNickname2);
        Console.WriteLine("NameProfTitle2: " + record.NameProfTitle2);
        Console.WriteLine("Gender2: " + record.Gender2);
        Console.WriteLine("Salutation: " + record.Salutation);
        Console.WriteLine("Extras: " + record.Extras + "\n\n");
      }
    }
    public void GlobalNameSetValueSample()
    {
      GlobalName globalName = new GlobalName(licenseKey);
      globalName.SetValue("FullName", "Raymond Melissa");

      string response = globalName.Get<string>();
      GlobalNameResponse responseObject = globalName.Get<GlobalNameResponse>();

      Console.WriteLine(response);

      Console.WriteLine($"\nVersion: {responseObject.Version}");
      Console.WriteLine($"TransmissionReference: {responseObject.TransmissionReference}");
      Console.WriteLine($"TransmissionResults: {responseObject.TransmissionResults}");
      Console.WriteLine($"TotalRecords: {responseObject.TotalRecords}\n");
      foreach (var record in responseObject.Records)
      {
        Console.WriteLine("RecordID: " + record.RecordID);
        Console.WriteLine("Results: " + record.Results);
        Console.WriteLine("Company: " + record.Company);
        Console.WriteLine("NamePrefix: " + record.NamePrefix);
        Console.WriteLine("NameFirst: " + record.NameFirst);
        Console.WriteLine("NameMiddle: " + record.NameMiddle);
        Console.WriteLine("NameLast: " + record.NameLast);
        Console.WriteLine("NameSuffix: " + record.NameSuffix);
        Console.WriteLine("NameNickname: " + record.NameNickname);
        Console.WriteLine("NameProfTitle: " + record.NameProfTitle);
        Console.WriteLine("Gender: " + record.Gender);
        Console.WriteLine("NamePrefix2: " + record.NamePrefix2);
        Console.WriteLine("NameFirst2: " + record.NameFirst2);
        Console.WriteLine("NameMiddle2: " + record.NameMiddle2);
        Console.WriteLine("NameLast2: " + record.NameLast2);
        Console.WriteLine("NameSuffix2: " + record.NameSuffix2);
        Console.WriteLine("NameNickname2: " + record.NameNickname2);
        Console.WriteLine("NameProfTitle2: " + record.NameProfTitle2);
        Console.WriteLine("Gender2: " + record.Gender2);
        Console.WriteLine("Salutation: " + record.Salutation);
        Console.WriteLine("Extras: " + record.Extras);
      }
    }

    public void GlobalNameSetValueSample2()
    {
      GlobalName globalName = new GlobalName(licenseKey);
      globalName.FullName = "Raymond Melissa";

      string response = globalName.Get<string>();
      GlobalNameResponse responseObject = globalName.Get<GlobalNameResponse>();

      Console.WriteLine(response);

      Console.WriteLine($"\nVersion: {responseObject.Version}");
      Console.WriteLine($"TransmissionReference: {responseObject.TransmissionReference}");
      Console.WriteLine($"TransmissionResults: {responseObject.TransmissionResults}");
      Console.WriteLine($"TotalRecords: {responseObject.TotalRecords}\n");
      foreach (var record in responseObject.Records)
      {
        Console.WriteLine("RecordID: " + record.RecordID);
        Console.WriteLine("Results: " + record.Results);
        Console.WriteLine("Company: " + record.Company);
        Console.WriteLine("NamePrefix: " + record.NamePrefix);
        Console.WriteLine("NameFirst: " + record.NameFirst);
        Console.WriteLine("NameMiddle: " + record.NameMiddle);
        Console.WriteLine("NameLast: " + record.NameLast);
        Console.WriteLine("NameSuffix: " + record.NameSuffix);
        Console.WriteLine("NameNickname: " + record.NameNickname);
        Console.WriteLine("NameProfTitle: " + record.NameProfTitle);
        Console.WriteLine("Gender: " + record.Gender);
        Console.WriteLine("NamePrefix2: " + record.NamePrefix2);
        Console.WriteLine("NameFirst2: " + record.NameFirst2);
        Console.WriteLine("NameMiddle2: " + record.NameMiddle2);
        Console.WriteLine("NameLast2: " + record.NameLast2);
        Console.WriteLine("NameSuffix2: " + record.NameSuffix2);
        Console.WriteLine("NameNickname2: " + record.NameNickname2);
        Console.WriteLine("NameProfTitle2: " + record.NameProfTitle2);
        Console.WriteLine("Gender2: " + record.Gender2);
        Console.WriteLine("Salutation: " + record.Salutation);
        Console.WriteLine("Extras: " + record.Extras);
      }
    }
  }
}
