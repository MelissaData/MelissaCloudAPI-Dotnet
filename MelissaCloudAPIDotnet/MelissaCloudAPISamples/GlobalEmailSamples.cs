using MelissaData.CloudAPI;

namespace MelissaCloudAPIDotnet.MelissaCloudAPISamples
{
  public class GlobalEmailSamples
  {
    public string licenseKey;

    public GlobalEmailSamples(string licenseKey)
    {
      this.licenseKey = licenseKey;
    }

    /// <summary>
    /// This function uses the Global Email Cloud API object to make a GET request
    /// </summary>
    public void GlobalEmailSample()
    {
      GlobalEmail globalEmail = new GlobalEmail(licenseKey);
      globalEmail.SetEmail("info@melissa.com");

      string response = globalEmail.Get<string>();
      GlobalEmailResponse responseObject = globalEmail.Get<GlobalEmailResponse>();

      Console.WriteLine(response);

      Console.WriteLine($"\nVersion: {responseObject.GetValue("Version")}");
      Console.WriteLine($"TransmissionReference: {responseObject.TransmissionReference}");
      Console.WriteLine($"TotalRecords: {responseObject.TotalRecords}\n");
      foreach (var record in responseObject.Records)
      {
        Console.WriteLine("RecordID: " + record.GetValue("RecordID"));
        Console.WriteLine("DeliverabilityConfidenceScore: " + record.GetValue("DeliverabilityConfidenceScore"));
        Console.WriteLine("Results: " + record.GetValue("Results"));
        Console.WriteLine("EmailAddress: " + record.GetValue("EmailAddress"));
        Console.WriteLine("MailboxName: " + record.GetValue("MailboxName"));
        Console.WriteLine("DomainName: " + record.GetValue("DomainName"));
        Console.WriteLine("DomainAuthenticationStatus: " + record.GetValue("DomainAuthenticationStatus"));
        Console.WriteLine("TopLevelDomain: " + record.GetValue("TopLevelDomain"));
        Console.WriteLine("TopLevelDomainName: " + record.GetValue("TopLevelDomainName"));
        Console.WriteLine("DateChecked: " + record.DateChecked);
        Console.WriteLine("EmailAgeEstimated: " + record.EmailAgeEstimated);
        Console.WriteLine("DomainAgeEstimated: " + record.DomainAgeEstimated);
        Console.WriteLine("DomainExpirationDate: " + record.DomainExpirationDate);
        Console.WriteLine("DomainCreatedDate: " + record.DomainCreatedDate);
        Console.WriteLine("DomainUpdatedDate: " + record.DomainUpdatedDate);
        Console.WriteLine("DomainEmail: " + record.DomainEmail);
        Console.WriteLine("DomainOrganization: " + record.DomainOrganization);
        Console.WriteLine("DomainAddress1: " + record.DomainAddress1);
        Console.WriteLine("DomainLocality: " + record.DomainLocality);
        Console.WriteLine("DomainAdministrativeArea: " + record.DomainAdministrativeArea);
        Console.WriteLine("DomainPostalCode: " + record.GetDomainPostalCode());
        Console.WriteLine("DomainCountry: " + record.GetDomainCountry());
        Console.WriteLine("DomainCountryCode: " + record.GetDomainCountry());
        Console.WriteLine("DomainAvailability: " + record.GetDomainAvailability());
        Console.WriteLine("DomainPrivateProxy: " + record.GetDomainPrivateProxy());
        Console.WriteLine("PrivacyFlag: " + record.GetPrivacyFlag());
        Console.WriteLine("MXServer: " + record.GetMXServer());
        Console.WriteLine("DomainTypeIndicator: " + record.GetDomainTypeIndicator());
        Console.WriteLine("BreachCount: " + record.GetBreachCount());
      }
    }

    /// <summary>
    /// This asynchronous function uses the Global Email Cloud API object to make a GET request
    /// </summary>
    public async Task GlobalEmailAsyncSample()
    {
      GlobalEmail globalEmail = new GlobalEmail(licenseKey);
      globalEmail.SetEmail("info@melissa.com");

      string response = await globalEmail.GetAsync<string>();
      GlobalEmailResponse responseObject = await globalEmail.GetAsync<GlobalEmailResponse>();

      Console.WriteLine(response);

      Console.WriteLine($"\nVersion: {responseObject.GetValue("Version")}");
      Console.WriteLine($"TransmissionReference: {responseObject.TransmissionReference}");
      Console.WriteLine($"TotalRecords: {responseObject.TotalRecords}\n");
      foreach (var record in responseObject.Records)
      {
        Console.WriteLine("RecordID: " + record.GetValue("RecordID"));
        Console.WriteLine("DeliverabilityConfidenceScore: " + record.GetValue("DeliverabilityConfidenceScore"));
        Console.WriteLine("Results: " + record.GetValue("Results"));
        Console.WriteLine("EmailAddress: " + record.GetValue("EmailAddress"));
        Console.WriteLine("MailboxName: " + record.GetValue("MailboxName"));
        Console.WriteLine("DomainName: " + record.GetValue("DomainName"));
        Console.WriteLine("DomainAuthenticationStatus: " + record.GetValue("DomainAuthenticationStatus"));
        Console.WriteLine("TopLevelDomain: " + record.GetValue("TopLevelDomain"));
        Console.WriteLine("TopLevelDomainName: " + record.GetValue("TopLevelDomainName"));
        Console.WriteLine("DateChecked: " + record.DateChecked);
        Console.WriteLine("EmailAgeEstimated: " + record.EmailAgeEstimated);
        Console.WriteLine("DomainAgeEstimated: " + record.DomainAgeEstimated);
        Console.WriteLine("DomainExpirationDate: " + record.DomainExpirationDate);
        Console.WriteLine("DomainCreatedDate: " + record.DomainCreatedDate);
        Console.WriteLine("DomainUpdatedDate: " + record.DomainUpdatedDate);
        Console.WriteLine("DomainEmail: " + record.DomainEmail);
        Console.WriteLine("DomainOrganization: " + record.DomainOrganization);
        Console.WriteLine("DomainAddress1: " + record.DomainAddress1);
        Console.WriteLine("DomainLocality: " + record.DomainLocality);
        Console.WriteLine("DomainAdministrativeArea: " + record.DomainAdministrativeArea);
        Console.WriteLine("DomainPostalCode: " + record.GetDomainPostalCode());
        Console.WriteLine("DomainCountry: " + record.GetDomainCountry());
        Console.WriteLine("DomainCountryCode: " + record.GetDomainCountry());
        Console.WriteLine("DomainAvailability: " + record.GetDomainAvailability());
        Console.WriteLine("DomainPrivateProxy: " + record.GetDomainPrivateProxy());
        Console.WriteLine("PrivacyFlag: " + record.GetPrivacyFlag());
        Console.WriteLine("MXServer: " + record.GetMXServer());
        Console.WriteLine("DomainTypeIndicator: " + record.GetDomainTypeIndicator());
        Console.WriteLine("BreachCount: " + record.GetBreachCount());
      }
    }

    /// <summary>
    /// This function uses the Global Email Cloud API object to make a POST BATCH request
    /// This function showcases method 1 of setting and making POST requests: construct the POST body structure using the Cloud API's respective PostRequest class
    /// </summary>
    public void GlobalEmailBatch1Sample()
    {
      GlobalEmail globalEmail = new GlobalEmail();
      globalEmail.SetPostBody(new GlobalEmailPostRequest
      {
        CustomerID = licenseKey,
        Records = new List<GlobalEmailRecordRequest>
        {
          new GlobalEmailRecordRequest
          {
            RecordID = "1",
            Email = "info@melissa.com"
          },
          new GlobalEmailRecordRequest
          {
            RecordID = "2",
            Email = "test@melissa.com"
          }
        }
      });

      string response = globalEmail.Post<string>();
      GlobalEmailResponse responseObject = globalEmail.Post<GlobalEmailResponse>();

      Console.WriteLine(response);

      Console.WriteLine($"\nVersion: {responseObject.Version}");
      Console.WriteLine($"TransmissionReference: {responseObject.TransmissionReference}");
      Console.WriteLine($"TotalRecords: {responseObject.TotalRecords}\n");
      foreach (var record in responseObject.Records)
      {
        Console.WriteLine("RecordID: " + record.RecordID);
        Console.WriteLine("Results: " + record.Results);
        Console.WriteLine("EmailAddress: " + record.EmailAddress);
        Console.WriteLine("MailboxName: " + record.MailboxName);
        Console.WriteLine("DomainName: " + record.DomainName);
        Console.WriteLine("DomainAuthenticationStatus: " + record.DomainAuthenticationStatus);
        Console.WriteLine("TopLevelDomain: " + record.TopLevelDomain);
        Console.WriteLine("TopLevelDomainName: " + record.TopLevelDomainName);
        Console.WriteLine("DateChecked: " + record.DateChecked);
        Console.WriteLine("EmailAgeEstimated: " + record.EmailAgeEstimated);
        Console.WriteLine("DeliverabilityConfidenceScore: " + record.DeliverabilityConfidenceScore);
        Console.WriteLine("DomainAgeEstimated: " + record.DomainAgeEstimated);
        Console.WriteLine("DomainExpirationDate: " + record.DomainExpirationDate);
        Console.WriteLine("DomainCreatedDate: " + record.DomainCreatedDate);
        Console.WriteLine("DomainUpdatedDate: " + record.DomainUpdatedDate);
        Console.WriteLine("DomainEmail: " + record.DomainEmail);
        Console.WriteLine("DomainOrganization: " + record.DomainOrganization);
        Console.WriteLine("DomainAddress1: " + record.DomainAddress1);
        Console.WriteLine("DomainLocality: " + record.DomainLocality);
        Console.WriteLine("DomainAdministrativeArea: " + record.DomainAdministrativeArea);
        Console.WriteLine("DomainPostalCode: " + record.DomainPostalCode);
        Console.WriteLine("DomainCountry: " + record.DomainCountry);
        Console.WriteLine("DomainCountryCode: " + record.DomainCountryCode);
        Console.WriteLine("DomainAvailability: " + record.DomainAvailability);
        Console.WriteLine("DomainPrivateProxy: " + record.DomainPrivateProxy);
        Console.WriteLine("PrivacyFlag: " + record.PrivacyFlag);
        Console.WriteLine("MXServer: " + record.MXServer);
        Console.WriteLine("DomainTypeIndicator: " + record.DomainTypeIndicator);
        Console.WriteLine("BreachCount: " + record.BreachCount + "\n\n");
      }
    }

    /// <summary>
    /// This function uses the Global Email Cloud API object to make a POST BATCH request
    /// This function showcases method 2 of setting and making POST requests: construct the POST body record by using the Cloud API's respective RecordRequest class
    /// </summary>>
    public void GlobalEmailBatch2Sample()
    {
      GlobalEmail globalEmail = new GlobalEmail(licenseKey);
      globalEmail.AddRecord(
          new GlobalEmailRecordRequest
          {
            RecordID = "1",
            Email = "info@melissa.com"
          }
      );
      globalEmail.AddRecord(
          new GlobalEmailRecordRequest
          {
            RecordID = "2",
            Email = "test@melissa.com"
          }
      );

      string response = globalEmail.Post<string>();
      GlobalEmailResponse responseObject = globalEmail.Post<GlobalEmailResponse>();

      Console.WriteLine(response);

      Console.WriteLine($"\nVersion: {responseObject.Version}");
      Console.WriteLine($"TransmissionReference: {responseObject.TransmissionReference}");
      Console.WriteLine($"TotalRecords: {responseObject.TotalRecords}\n");
      foreach (var record in responseObject.Records)
      {
        Console.WriteLine("RecordID: " + record.RecordID);
        Console.WriteLine("Results: " + record.Results);
        Console.WriteLine("EmailAddress: " + record.EmailAddress);
        Console.WriteLine("MailboxName: " + record.MailboxName);
        Console.WriteLine("DomainName: " + record.DomainName);
        Console.WriteLine("DomainAuthenticationStatus: " + record.DomainAuthenticationStatus);
        Console.WriteLine("TopLevelDomain: " + record.TopLevelDomain);
        Console.WriteLine("TopLevelDomainName: " + record.TopLevelDomainName);
        Console.WriteLine("DateChecked: " + record.DateChecked);
        Console.WriteLine("EmailAgeEstimated: " + record.EmailAgeEstimated);
        Console.WriteLine("DeliverabilityConfidenceScore: " + record.DeliverabilityConfidenceScore);
        Console.WriteLine("DomainAgeEstimated: " + record.DomainAgeEstimated);
        Console.WriteLine("DomainExpirationDate: " + record.DomainExpirationDate);
        Console.WriteLine("DomainCreatedDate: " + record.DomainCreatedDate);
        Console.WriteLine("DomainUpdatedDate: " + record.DomainUpdatedDate);
        Console.WriteLine("DomainEmail: " + record.DomainEmail);
        Console.WriteLine("DomainOrganization: " + record.DomainOrganization);
        Console.WriteLine("DomainAddress1: " + record.DomainAddress1);
        Console.WriteLine("DomainLocality: " + record.DomainLocality);
        Console.WriteLine("DomainAdministrativeArea: " + record.DomainAdministrativeArea);
        Console.WriteLine("DomainPostalCode: " + record.DomainPostalCode);
        Console.WriteLine("DomainCountry: " + record.DomainCountry);
        Console.WriteLine("DomainCountryCode: " + record.DomainCountryCode);
        Console.WriteLine("DomainAvailability: " + record.DomainAvailability);
        Console.WriteLine("DomainPrivateProxy: " + record.DomainPrivateProxy);
        Console.WriteLine("PrivacyFlag: " + record.PrivacyFlag);
        Console.WriteLine("MXServer: " + record.MXServer);
        Console.WriteLine("DomainTypeIndicator: " + record.DomainTypeIndicator);
        Console.WriteLine("BreachCount: " + record.BreachCount + "\n\n");
      }
    }

    /// <summary>
    /// This asynchronous function uses the Global Email Cloud API object to make a POST request
    /// </summary>
    public async Task GlobalEmailBatchAsyncSample()
    {
      GlobalEmail globalEmail = new GlobalEmail();
      globalEmail.SetPostBody(new GlobalEmailPostRequest
      {
        CustomerID = licenseKey,
        Records = new List<GlobalEmailRecordRequest>
        {
          new GlobalEmailRecordRequest
          {
            RecordID = "1",
            Email = "info@melissa.com"
          },
          new GlobalEmailRecordRequest
          {
            RecordID = "2",
            Email = "test@melissa.com"
          }
        }
      });

      string response = await globalEmail.PostAsync<string>();
      GlobalEmailResponse responseObject = await globalEmail.PostAsync<GlobalEmailResponse>();

      Console.WriteLine(response);

      Console.WriteLine($"\nVersion: {responseObject.Version}");
      Console.WriteLine($"TransmissionReference: {responseObject.TransmissionReference}");
      Console.WriteLine($"TotalRecords: {responseObject.TotalRecords}\n");
      foreach (var record in responseObject.Records)
      {
        Console.WriteLine("RecordID: " + record.RecordID);
        Console.WriteLine("Results: " + record.Results);
        Console.WriteLine("EmailAddress: " + record.EmailAddress);
        Console.WriteLine("MailboxName: " + record.MailboxName);
        Console.WriteLine("DomainName: " + record.DomainName);
        Console.WriteLine("DomainAuthenticationStatus: " + record.DomainAuthenticationStatus);
        Console.WriteLine("TopLevelDomain: " + record.TopLevelDomain);
        Console.WriteLine("TopLevelDomainName: " + record.TopLevelDomainName);
        Console.WriteLine("DateChecked: " + record.DateChecked);
        Console.WriteLine("EmailAgeEstimated: " + record.EmailAgeEstimated);
        Console.WriteLine("DeliverabilityConfidenceScore: " + record.DeliverabilityConfidenceScore);
        Console.WriteLine("DomainAgeEstimated: " + record.DomainAgeEstimated);
        Console.WriteLine("DomainExpirationDate: " + record.DomainExpirationDate);
        Console.WriteLine("DomainCreatedDate: " + record.DomainCreatedDate);
        Console.WriteLine("DomainUpdatedDate: " + record.DomainUpdatedDate);
        Console.WriteLine("DomainEmail: " + record.DomainEmail);
        Console.WriteLine("DomainOrganization: " + record.DomainOrganization);
        Console.WriteLine("DomainAddress1: " + record.DomainAddress1);
        Console.WriteLine("DomainLocality: " + record.DomainLocality);
        Console.WriteLine("DomainAdministrativeArea: " + record.DomainAdministrativeArea);
        Console.WriteLine("DomainPostalCode: " + record.DomainPostalCode);
        Console.WriteLine("DomainCountry: " + record.DomainCountry);
        Console.WriteLine("DomainCountryCode: " + record.DomainCountryCode);
        Console.WriteLine("DomainAvailability: " + record.DomainAvailability);
        Console.WriteLine("DomainPrivateProxy: " + record.DomainPrivateProxy);
        Console.WriteLine("PrivacyFlag: " + record.PrivacyFlag);
        Console.WriteLine("MXServer: " + record.MXServer);
        Console.WriteLine("DomainTypeIndicator: " + record.DomainTypeIndicator);
        Console.WriteLine("BreachCount: " + record.BreachCount + "\n\n");
      }
    }

    public void GlobalEmailSetValueSample()
    {
      GlobalEmail globalEmail = new GlobalEmail(licenseKey);
      globalEmail.SetValue("Email", "info@melissa.com");

      string response = globalEmail.Get<string>();
      GlobalEmailResponse responseObject = globalEmail.Get<GlobalEmailResponse>();

      Console.WriteLine(response);

      Console.WriteLine($"\nVersion: {responseObject.GetValue("Version")}");
      Console.WriteLine($"TransmissionReference: {responseObject.TransmissionReference}");
      Console.WriteLine($"TotalRecords: {responseObject.TotalRecords}\n");
      foreach (var record in responseObject.Records)
      {
        Console.WriteLine("RecordID: " + record.GetValue("RecordID"));
        Console.WriteLine("DeliverabilityConfidenceScore: " + record.GetValue("DeliverabilityConfidenceScore"));
        Console.WriteLine("Results: " + record.GetValue("Results"));
        Console.WriteLine("EmailAddress: " + record.GetValue("EmailAddress"));
        Console.WriteLine("MailboxName: " + record.GetValue("MailboxName"));
        Console.WriteLine("DomainName: " + record.GetValue("DomainName"));
        Console.WriteLine("DomainAuthenticationStatus: " + record.GetValue("DomainAuthenticationStatus"));
        Console.WriteLine("TopLevelDomain: " + record.GetValue("TopLevelDomain"));
        Console.WriteLine("TopLevelDomainName: " + record.GetValue("TopLevelDomainName"));
        Console.WriteLine("DateChecked: " + record.DateChecked);
        Console.WriteLine("EmailAgeEstimated: " + record.EmailAgeEstimated);
        Console.WriteLine("DomainAgeEstimated: " + record.DomainAgeEstimated);
        Console.WriteLine("DomainExpirationDate: " + record.DomainExpirationDate);
        Console.WriteLine("DomainCreatedDate: " + record.DomainCreatedDate);
        Console.WriteLine("DomainUpdatedDate: " + record.DomainUpdatedDate);
        Console.WriteLine("DomainEmail: " + record.DomainEmail);
        Console.WriteLine("DomainOrganization: " + record.DomainOrganization);
        Console.WriteLine("DomainAddress1: " + record.DomainAddress1);
        Console.WriteLine("DomainLocality: " + record.DomainLocality);
        Console.WriteLine("DomainAdministrativeArea: " + record.DomainAdministrativeArea);
        Console.WriteLine("DomainPostalCode: " + record.GetDomainPostalCode());
        Console.WriteLine("DomainCountry: " + record.GetDomainCountry());
        Console.WriteLine("DomainCountryCode: " + record.GetDomainCountry());
        Console.WriteLine("DomainAvailability: " + record.GetDomainAvailability());
        Console.WriteLine("DomainPrivateProxy: " + record.GetDomainPrivateProxy());
        Console.WriteLine("PrivacyFlag: " + record.GetPrivacyFlag());
        Console.WriteLine("MXServer: " + record.GetMXServer());
        Console.WriteLine("DomainTypeIndicator: " + record.GetDomainTypeIndicator());
        Console.WriteLine("BreachCount: " + record.GetBreachCount());
      }
    }

    public void GlobalEmailSetValueSample2()
    {
      GlobalEmail globalEmail = new GlobalEmail(licenseKey);
      globalEmail.Email = "info@melissa.com";

      string response = globalEmail.Get<string>();
      GlobalEmailResponse responseObject = globalEmail.Get<GlobalEmailResponse>();

      Console.WriteLine(response);

      Console.WriteLine($"\nVersion: {responseObject.GetValue("Version")}");
      Console.WriteLine($"TransmissionReference: {responseObject.TransmissionReference}");
      Console.WriteLine($"TotalRecords: {responseObject.TotalRecords}\n");
      foreach (var record in responseObject.Records)
      {
        Console.WriteLine("RecordID: " + record.GetValue("RecordID"));
        Console.WriteLine("DeliverabilityConfidenceScore: " + record.GetValue("DeliverabilityConfidenceScore"));
        Console.WriteLine("Results: " + record.GetValue("Results"));
        Console.WriteLine("EmailAddress: " + record.GetValue("EmailAddress"));
        Console.WriteLine("MailboxName: " + record.GetValue("MailboxName"));
        Console.WriteLine("DomainName: " + record.GetValue("DomainName"));
        Console.WriteLine("DomainAuthenticationStatus: " + record.GetValue("DomainAuthenticationStatus"));
        Console.WriteLine("TopLevelDomain: " + record.GetValue("TopLevelDomain"));
        Console.WriteLine("TopLevelDomainName: " + record.GetValue("TopLevelDomainName"));
        Console.WriteLine("DateChecked: " + record.DateChecked);
        Console.WriteLine("EmailAgeEstimated: " + record.EmailAgeEstimated);
        Console.WriteLine("DomainAgeEstimated: " + record.DomainAgeEstimated);
        Console.WriteLine("DomainExpirationDate: " + record.DomainExpirationDate);
        Console.WriteLine("DomainCreatedDate: " + record.DomainCreatedDate);
        Console.WriteLine("DomainUpdatedDate: " + record.DomainUpdatedDate);
        Console.WriteLine("DomainEmail: " + record.DomainEmail);
        Console.WriteLine("DomainOrganization: " + record.DomainOrganization);
        Console.WriteLine("DomainAddress1: " + record.DomainAddress1);
        Console.WriteLine("DomainLocality: " + record.DomainLocality);
        Console.WriteLine("DomainAdministrativeArea: " + record.DomainAdministrativeArea);
        Console.WriteLine("DomainPostalCode: " + record.GetDomainPostalCode());
        Console.WriteLine("DomainCountry: " + record.GetDomainCountry());
        Console.WriteLine("DomainCountryCode: " + record.GetDomainCountry());
        Console.WriteLine("DomainAvailability: " + record.GetDomainAvailability());
        Console.WriteLine("DomainPrivateProxy: " + record.GetDomainPrivateProxy());
        Console.WriteLine("PrivacyFlag: " + record.GetPrivacyFlag());
        Console.WriteLine("MXServer: " + record.GetMXServer());
        Console.WriteLine("DomainTypeIndicator: " + record.GetDomainTypeIndicator());
        Console.WriteLine("BreachCount: " + record.GetBreachCount());
      }
    }
  }
}
