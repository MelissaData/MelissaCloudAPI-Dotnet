using MelissaData.CloudAPI;

namespace MelissaCloudAPIDotnet.MelissaCloudAPISamples
{
  public class SSNNameMatchSamples
  {
    public string licenseKey;

    public SSNNameMatchSamples(string licenseKey)
    {
      this.licenseKey = licenseKey;
    }

    /// <summary>
    /// This function uses the SSN Name Match Cloud API object to make a GET request
    /// </summary>
    public void SSNNameMatchSample()
    {
      SSNNameMatch ssnNameMatch = new SSNNameMatch(licenseKey);
      ssnNameMatch.SetSSN("111223333");

      string response = ssnNameMatch.Get<string>();
      SSNNameMatchResponse responseObject = ssnNameMatch.Get<SSNNameMatchResponse>();

      Console.WriteLine(response);

      Console.WriteLine($"\nTransmissionResults: {responseObject.TransmissionResults}");
      Console.WriteLine($"Version: {responseObject.Version}");
      Console.WriteLine($"TotalRecords: {responseObject.TotalRecords}");
      foreach (var record in responseObject.Records)
      {
        Console.WriteLine($"\nRecordID: {record.RecordID}");
        Console.WriteLine($"SSN: {record.SSN}");
        Console.WriteLine($"IssuingState: {record.IssuingState}");
        Console.WriteLine($"Results: {record.Results}");
        Console.WriteLine($"ResultsFromDataSource: {record.ResultsFromDataSource}");
      }
    }

    /// <summary>
    /// This asynchronous function uses the SSN Name Match Cloud API object to make a GET request
    /// </summary>
    public async Task SSNNameMatchAsyncSample()
    {
      SSNNameMatch ssnNameMatch = new SSNNameMatch(licenseKey);
      ssnNameMatch.SetSSN("111223333");

      string response = await ssnNameMatch.GetAsync<string>();
      SSNNameMatchResponse responseObject = await ssnNameMatch.GetAsync<SSNNameMatchResponse>();

      Console.WriteLine(response);

      Console.WriteLine($"\nTransmissionResults: {responseObject.TransmissionResults}");
      Console.WriteLine($"Version: {responseObject.Version}");
      Console.WriteLine($"TotalRecords: {responseObject.TotalRecords}");
      foreach (var record in responseObject.Records)
      {
        Console.WriteLine($"\nRecordID: {record.RecordID}");
        Console.WriteLine($"SSN: {record.SSN}");
        Console.WriteLine($"IssuingState: {record.IssuingState}");
        Console.WriteLine($"Results: {record.Results}");
        Console.WriteLine($"ResultsFromDataSource: {record.ResultsFromDataSource}");
      }
    }

    /// <summary>
    /// This function uses the SSN Name Match Cloud API object to make a POST BATCH request
    /// This function showcases method 1 of setting and making POST requests: construct the POST body structure using the Cloud API's respective PostRequest class
    /// </summary>
    public void SSNNameMatchBatch1Sample()
    {
      SSNNameMatch nameMatch = new SSNNameMatch();

      nameMatch.SetPostBody(new SSNNameMatchPostRequest
      {
        CustomerID = licenseKey,
        Records = new List<SSNNameMatchRecordRequest>
        {
          new SSNNameMatchRecordRequest
          {
            RecordID = "1",
            SSN = "111223333"
          },
          new SSNNameMatchRecordRequest
          {
            RecordID = "2",
            SSN = "419251021"
          }
        }
      });

      string response = nameMatch.Post<string>();
      SSNNameMatchResponse responseObject = nameMatch.Post<SSNNameMatchResponse>();

      Console.WriteLine(response);

      Console.WriteLine($"\nTransmissionResults: {responseObject.TransmissionResults}");
      Console.WriteLine($"TransmissionReference: {responseObject.TransmissionReference}");
      Console.WriteLine($"Version: {responseObject.Version}");
      Console.WriteLine($"TotalRecords: {responseObject.TotalRecords}");
      foreach (var record in responseObject.Records)
      {
        Console.WriteLine($"\nRecordID: {record.RecordID}");
        Console.WriteLine($"SSN: {record.SSN}");
        Console.WriteLine($"IssuingState: {record.IssuingState}");
        Console.WriteLine($"Results: {record.Results}");
        Console.WriteLine($"ResultsFromDataSource: {record.ResultsFromDataSource}");
      }
    }

    /// <summary>
    /// This function uses the SSN Name Match Cloud API object to make a POST BATCH request
    /// This function showcases method 2 of setting and making POST requests: construct the POST body record by using the Cloud API's respective RecordRequest class
    /// </summary>

    public void SSNNameMatchBatch2Sample()
    {
      SSNNameMatch nameMatch = new SSNNameMatch(licenseKey);

      nameMatch.AddRecord(new SSNNameMatchRecordRequest
      {
        RecordID = "1",
        SSN = "111223333"
      });
      nameMatch.AddRecord(new SSNNameMatchRecordRequest
      {
        RecordID = "2",
        SSN = "419251021"
      });

      string response = nameMatch.Post<string>();
      SSNNameMatchResponse responseObject = nameMatch.Post<SSNNameMatchResponse>();

      Console.WriteLine(response);

      Console.WriteLine($"\nTransmissionResults: {responseObject.TransmissionResults}");
      Console.WriteLine($"TransmissionReference: {responseObject.TransmissionReference}");
      Console.WriteLine($"Version: {responseObject.Version}");
      Console.WriteLine($"TotalRecords: {responseObject.TotalRecords}");
      foreach (var record in responseObject.Records)
      {
        Console.WriteLine($"\nRecordID: {record.RecordID}");
        Console.WriteLine($"SSN: {record.SSN}");
        Console.WriteLine($"IssuingState: {record.IssuingState}");
        Console.WriteLine($"Results: {record.Results}");
        Console.WriteLine($"ResultsFromDataSource: {record.ResultsFromDataSource}");
      }
    }

    /// <summary>
    /// This asynchronous function uses the SSN Name Match Cloud API object to make a POST BATCH request
    /// This function showcases method 1 of setting and making POST requests: construct the POST body structure using the Cloud API's respective PostRequest class
    /// </summary>
    public async Task SSNNameMatchBatchAsyncSample()
    {
      SSNNameMatch nameMatch = new SSNNameMatch();

      nameMatch.SetPostBody(new SSNNameMatchPostRequest
      {
        CustomerID = licenseKey,
        Records = new List<SSNNameMatchRecordRequest>
        {
          new SSNNameMatchRecordRequest
          {
            RecordID = "1",
            SSN = "111223333"
          },
          new SSNNameMatchRecordRequest
          {
            RecordID = "2",
            SSN = "419251021"
          }
        }
      });

      string response = await nameMatch.PostAsync<string>();
      SSNNameMatchResponse responseObject = await nameMatch.PostAsync<SSNNameMatchResponse>();

      Console.WriteLine(response);

      Console.WriteLine($"\nTransmissionResults: {responseObject.TransmissionResults}");
      Console.WriteLine($"TransmissionReference: {responseObject.TransmissionReference}");
      Console.WriteLine($"Version: {responseObject.Version}");
      Console.WriteLine($"TotalRecords: {responseObject.TotalRecords}");
      foreach (var record in responseObject.Records)
      {
        Console.WriteLine($"\nRecordID: {record.RecordID}");
        Console.WriteLine($"SSN: {record.SSN}");
        Console.WriteLine($"IssuingState: {record.IssuingState}");
        Console.WriteLine($"Results: {record.Results}");
        Console.WriteLine($"ResultsFromDataSource: {record.ResultsFromDataSource}");
      }
    }

    public void SSNNameMatchSetValueSample()
    {
      SSNNameMatch ssnNameMatch = new SSNNameMatch(licenseKey);
      ssnNameMatch.SetValue("SSN", "111223333");

      string response = ssnNameMatch.Get<string>();
      SSNNameMatchResponse responseObject = ssnNameMatch.Get<SSNNameMatchResponse>();

      Console.WriteLine(response);

      Console.WriteLine($"\nTransmissionResults: {responseObject.TransmissionResults}");
      Console.WriteLine($"Version: {responseObject.Version}");
      Console.WriteLine($"TotalRecords: {responseObject.TotalRecords}");
      foreach (var record in responseObject.Records)
      {
        Console.WriteLine($"\nRecordID: {record.RecordID}");
        Console.WriteLine($"SSN: {record.SSN}");
        Console.WriteLine($"IssuingState: {record.IssuingState}");
        Console.WriteLine($"Results: {record.Results}");
        Console.WriteLine($"ResultsFromDataSource: {record.ResultsFromDataSource}");
      }
    }

    public void SSNNameMatchSetValueSample2()
    {
      SSNNameMatch ssnNameMatch = new SSNNameMatch(licenseKey);
      ssnNameMatch.SSN = "111223333";

      string response = ssnNameMatch.Get<string>();
      SSNNameMatchResponse responseObject = ssnNameMatch.Get<SSNNameMatchResponse>();

      Console.WriteLine(response);

      Console.WriteLine($"\nTransmissionResults: {responseObject.TransmissionResults}");
      Console.WriteLine($"Version: {responseObject.Version}");
      Console.WriteLine($"TotalRecords: {responseObject.TotalRecords}");
      foreach (var record in responseObject.Records)
      {
        Console.WriteLine($"\nRecordID: {record.RecordID}");
        Console.WriteLine($"SSN: {record.SSN}");
        Console.WriteLine($"IssuingState: {record.IssuingState}");
        Console.WriteLine($"Results: {record.Results}");
        Console.WriteLine($"ResultsFromDataSource: {record.ResultsFromDataSource}");
      }
    }
  }
}
