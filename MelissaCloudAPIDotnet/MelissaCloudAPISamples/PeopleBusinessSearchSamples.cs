using MelissaData.CloudAPI;

namespace MelissaCloudAPIDotnet.MelissaCloudAPISamples
{
  public class PeopleBusinessSearchSamples
  {
    public string licenseKey;

    public PeopleBusinessSearchSamples(string licenseKey)
    {
      this.licenseKey = licenseKey;
    }

    /// <summary>
    /// This function uses the People Business Search Cloud API object to test both GET and POST
    /// </summary>
    public void PeopleBusinessSearchSample()
    {
      PeopleBusinessSearch peopleBusiness = new PeopleBusinessSearch(licenseKey);
      peopleBusiness.SetMaxRecords("10");
      peopleBusiness.SetMatchLevel("10");
      peopleBusiness.SetAddressLine1("22382 Avenida Empresa");
      peopleBusiness.SetLocality("RSM");
      peopleBusiness.SetAdministrativeArea("CA");
      peopleBusiness.SetPostal("92688");
      peopleBusiness.SetAnyName("Melissa Data");

      string response = peopleBusiness.Get<string>();
      PeopleBusinessSearchResponse responseObject = peopleBusiness.Get<PeopleBusinessSearchResponse>();

      Console.WriteLine(response);

      Console.WriteLine($"TransmissionReference: {responseObject.TransmissionReference}");
      Console.WriteLine($"Version: {responseObject.Version}");
      Console.WriteLine($"ResultCode: {responseObject.ResultCode}");
      Console.WriteLine($"TotalRecords: {responseObject.TotalRecords}");
      foreach (var record in responseObject.Results)
      {
        Console.WriteLine($"\nMatchLevel: {record.MatchLevel}");

        Console.WriteLine($"Address:");
        Console.WriteLine($"\tAddress1: {record.Address.Address1}");
        Console.WriteLine($"\tLocality: {record.Address.Locality}");
        Console.WriteLine($"\tLocalityAlternates: {record.Address.LocalityAlternates}");
        Console.WriteLine($"\tAdministrativeArea: {record.Address.AdministrativeArea}");
        Console.WriteLine($"\tCountryCode: {record.Address.CountryCode}");
        Console.WriteLine($"\tCountryName: {record.Address.CountryName}");
        Console.WriteLine($"\tThoroughfare: {record.Address.Thoroughfare}");
        Console.WriteLine($"\tThoroughfareName: {record.Address.ThoroughfareName}");
        Console.WriteLine($"\tPremises: {record.Address.Premises}");
        Console.WriteLine($"\tPremiseNumber: {record.Address.PremiseNumber}");
        Console.WriteLine($"\tPostalCode: {record.Address.PostalCode}");
        Console.WriteLine($"\tPostalCodeSecondary: {record.Address.PostalCodeSecondary}");
        Console.WriteLine($"\tMelissaAddressKey: {record.Address.MelissaAddressKey}");

        Console.WriteLine($"Consumer:");
        Console.WriteLine($"\tFullname: {record.Consumer.FullName}");
        Console.WriteLine($"\tFirstName: {record.Consumer.FirstName}");
        Console.WriteLine($"\tLastName: {record.Consumer.LastName}");
        Console.WriteLine($"\tMelissaIdentityKey: {record.Consumer.MelissaIdentityKey}");

        Console.WriteLine($"Phone:");
        Console.WriteLine($"\tPhone: {record.Phone.Phone}");
      }

      peopleBusiness = new PeopleBusinessSearch(licenseKey);
      peopleBusiness.SetPostBody(new PeopleBusinessSearchRecordRequest
      {
        CustomerID = licenseKey,
        MaxRecords = "10",
        MatchLevel = "10",
        AddressLine1 = "22382 Avenida Empresa",
        Locality = "RSM",
        AdministrativeArea = "CA",
        PostalCode = "92688",
        AnyName = "Melissa Data"
      });

      response = peopleBusiness.Post<string>();
      responseObject = peopleBusiness.Post<PeopleBusinessSearchResponse>();

      Console.WriteLine(response);

      Console.WriteLine($"TransmissionReference: {responseObject.TransmissionReference}");
      Console.WriteLine($"Version: {responseObject.Version}");
      Console.WriteLine($"ResultCode: {responseObject.ResultCode}");
      Console.WriteLine($"TotalRecords: {responseObject.TotalRecords}");
      foreach (var record in responseObject.Results)
      {
        Console.WriteLine($"\nMatchLevel: {record.MatchLevel}");

        Console.WriteLine($"Address:");
        Console.WriteLine($"\tAddress1: {record.Address.Address1}");
        Console.WriteLine($"\tLocality: {record.Address.Locality}");
        Console.WriteLine($"\tLocalityAlternates: {record.Address.LocalityAlternates}");
        Console.WriteLine($"\tAdministrativeArea: {record.Address.AdministrativeArea}");
        Console.WriteLine($"\tCountryCode: {record.Address.CountryCode}");
        Console.WriteLine($"\tCountryName: {record.Address.CountryName}");
        Console.WriteLine($"\tThoroughfare: {record.Address.Thoroughfare}");
        Console.WriteLine($"\tThoroughfareName: {record.Address.ThoroughfareName}");
        Console.WriteLine($"\tPremises: {record.Address.Premises}");
        Console.WriteLine($"\tPremiseNumber: {record.Address.PremiseNumber}");
        Console.WriteLine($"\tPostalCode: {record.Address.PostalCode}");
        Console.WriteLine($"\tPostalCodeSecondary: {record.Address.PostalCodeSecondary}");
        Console.WriteLine($"\tMelissaAddressKey: {record.Address.MelissaAddressKey}");

        Console.WriteLine($"Consumer:");
        Console.WriteLine($"\tFullname: {record.Consumer.FullName}");
        Console.WriteLine($"\tFirstName: {record.Consumer.FirstName}");
        Console.WriteLine($"\tLastName: {record.Consumer.LastName}");
        Console.WriteLine($"\tMelissaIdentityKey: {record.Consumer.MelissaIdentityKey}");

        Console.WriteLine($"Phone:");
        Console.WriteLine($"\tPhone: {record.Phone.Phone}");
      }
    }

    /// <summary>
    /// This asynchronous function uses the People Business Search Cloud API object to test both GET and POST
    /// </summary>
    public async Task PeopleBusinessSearchAsyncSample()
    {
      PeopleBusinessSearch peopleBusiness = new PeopleBusinessSearch(licenseKey);
      peopleBusiness.SetMaxRecords("10");
      peopleBusiness.SetMatchLevel("10");
      peopleBusiness.SetAddressLine1("22382 Avenida Empresa");
      peopleBusiness.SetLocality("RSM");
      peopleBusiness.SetAdministrativeArea("CA");
      peopleBusiness.SetPostal("92688");
      peopleBusiness.SetAnyName("Melissa Data");

      string response = await peopleBusiness.GetAsync<string>();
      PeopleBusinessSearchResponse responseObject = await peopleBusiness.GetAsync<PeopleBusinessSearchResponse>();

      Console.WriteLine(response);

      Console.WriteLine($"TransmissionReference: {responseObject.TransmissionReference}");
      Console.WriteLine($"Version: {responseObject.Version}");
      Console.WriteLine($"ResultCode: {responseObject.ResultCode}");
      Console.WriteLine($"TotalRecords: {responseObject.TotalRecords}");
      foreach (var record in responseObject.Results)
      {
        Console.WriteLine($"\nMatchLevel: {record.MatchLevel}");

        Console.WriteLine($"Address:");
        Console.WriteLine($"\tAddress1: {record.Address.Address1}");
        Console.WriteLine($"\tLocality: {record.Address.Locality}");
        Console.WriteLine($"\tLocalityAlternates: {record.Address.LocalityAlternates}");
        Console.WriteLine($"\tAdministrativeArea: {record.Address.AdministrativeArea}");
        Console.WriteLine($"\tCountryCode: {record.Address.CountryCode}");
        Console.WriteLine($"\tCountryName: {record.Address.CountryName}");
        Console.WriteLine($"\tThoroughfare: {record.Address.Thoroughfare}");
        Console.WriteLine($"\tThoroughfareName: {record.Address.ThoroughfareName}");
        Console.WriteLine($"\tPremises: {record.Address.Premises}");
        Console.WriteLine($"\tPremiseNumber: {record.Address.PremiseNumber}");
        Console.WriteLine($"\tPostalCode: {record.Address.PostalCode}");
        Console.WriteLine($"\tPostalCodeSecondary: {record.Address.PostalCodeSecondary}");
        Console.WriteLine($"\tMelissaAddressKey: {record.Address.MelissaAddressKey}");

        Console.WriteLine($"Consumer:");
        Console.WriteLine($"\tFullname: {record.Consumer.FullName}");
        Console.WriteLine($"\tFirstName: {record.Consumer.FirstName}");
        Console.WriteLine($"\tLastName: {record.Consumer.LastName}");
        Console.WriteLine($"\tMelissaIdentityKey: {record.Consumer.MelissaIdentityKey}");

        Console.WriteLine($"Phone:");
        Console.WriteLine($"\tPhone: {record.Phone.Phone}");
      }

      peopleBusiness = new PeopleBusinessSearch(licenseKey);
      peopleBusiness.SetPostBody(new PeopleBusinessSearchRecordRequest
      {
        CustomerID = licenseKey,
        MaxRecords = "10",
        MatchLevel = "10",
        AddressLine1 = "22382 Avenida Empresa",
        Locality = "RSM",
        AdministrativeArea = "CA",
        PostalCode = "92688",
        AnyName = "Melissa Data"
      });

      response = await peopleBusiness.PostAsync<string>();
      responseObject = await peopleBusiness.PostAsync<PeopleBusinessSearchResponse>();

      Console.WriteLine(response);

      Console.WriteLine($"TransmissionReference: {responseObject.TransmissionReference}");
      Console.WriteLine($"Version: {responseObject.Version}");
      Console.WriteLine($"ResultCode: {responseObject.ResultCode}");
      Console.WriteLine($"TotalRecords: {responseObject.TotalRecords}");
      foreach (var record in responseObject.Results)
      {
        Console.WriteLine($"\nMatchLevel: {record.MatchLevel}");

        Console.WriteLine($"Address:");
        Console.WriteLine($"\tAddress1: {record.Address.Address1}");
        Console.WriteLine($"\tLocality: {record.Address.Locality}");
        Console.WriteLine($"\tLocalityAlternates: {record.Address.LocalityAlternates}");
        Console.WriteLine($"\tAdministrativeArea: {record.Address.AdministrativeArea}");
        Console.WriteLine($"\tCountryCode: {record.Address.CountryCode}");
        Console.WriteLine($"\tCountryName: {record.Address.CountryName}");
        Console.WriteLine($"\tThoroughfare: {record.Address.Thoroughfare}");
        Console.WriteLine($"\tThoroughfareName: {record.Address.ThoroughfareName}");
        Console.WriteLine($"\tPremises: {record.Address.Premises}");
        Console.WriteLine($"\tPremiseNumber: {record.Address.PremiseNumber}");
        Console.WriteLine($"\tPostalCode: {record.Address.PostalCode}");
        Console.WriteLine($"\tPostalCodeSecondary: {record.Address.PostalCodeSecondary}");
        Console.WriteLine($"\tMelissaAddressKey: {record.Address.MelissaAddressKey}");

        Console.WriteLine($"Consumer:");
        Console.WriteLine($"\tFullname: {record.Consumer.FullName}");
        Console.WriteLine($"\tFirstName: {record.Consumer.FirstName}");
        Console.WriteLine($"\tLastName: {record.Consumer.LastName}");
        Console.WriteLine($"\tMelissaIdentityKey: {record.Consumer.MelissaIdentityKey}");

        Console.WriteLine($"Phone:");
        Console.WriteLine($"\tPhone: {record.Phone.Phone}");
      }
    }

    public void PeopleBusinessSearchSetValueSample()
    {
      PeopleBusinessSearch peopleBusiness = new PeopleBusinessSearch(licenseKey);
      peopleBusiness.SetValue("MaxRecords", "10");
      peopleBusiness.SetValue("MatchLevel", "10");
      peopleBusiness.SetValue("AddressLine1", "22382 Avenida Empresa");
      peopleBusiness.SetValue("Locality", "RSM");
      peopleBusiness.SetValue("AdministrativeArea", "CA");
      peopleBusiness.SetValue("Postal", "92688");
      peopleBusiness.SetValue("AnyName", "Melissa Data");

      string response = peopleBusiness.Get<string>();
      PeopleBusinessSearchResponse responseObject = peopleBusiness.Get<PeopleBusinessSearchResponse>();

      Console.WriteLine(response);

      Console.WriteLine($"TransmissionReference: {responseObject.TransmissionReference}");
      Console.WriteLine($"Version: {responseObject.Version}");
      Console.WriteLine($"ResultCode: {responseObject.ResultCode}");
      Console.WriteLine($"TotalRecords: {responseObject.TotalRecords}");
      foreach (var record in responseObject.Results)
      {
        Console.WriteLine($"\nMatchLevel: {record.MatchLevel}");

        Console.WriteLine($"Address:");
        Console.WriteLine($"\tAddress1: {record.Address.Address1}");
        Console.WriteLine($"\tLocality: {record.Address.Locality}");
        Console.WriteLine($"\tLocalityAlternates: {record.Address.LocalityAlternates}");
        Console.WriteLine($"\tAdministrativeArea: {record.Address.AdministrativeArea}");
        Console.WriteLine($"\tCountryCode: {record.Address.CountryCode}");
        Console.WriteLine($"\tCountryName: {record.Address.CountryName}");
        Console.WriteLine($"\tThoroughfare: {record.Address.Thoroughfare}");
        Console.WriteLine($"\tThoroughfareName: {record.Address.ThoroughfareName}");
        Console.WriteLine($"\tPremises: {record.Address.Premises}");
        Console.WriteLine($"\tPremiseNumber: {record.Address.PremiseNumber}");
        Console.WriteLine($"\tPostalCode: {record.Address.PostalCode}");
        Console.WriteLine($"\tPostalCodeSecondary: {record.Address.PostalCodeSecondary}");
        Console.WriteLine($"\tMelissaAddressKey: {record.Address.MelissaAddressKey}");

        Console.WriteLine($"Consumer:");
        Console.WriteLine($"\tFullname: {record.Consumer.FullName}");
        Console.WriteLine($"\tFirstName: {record.Consumer.FirstName}");
        Console.WriteLine($"\tLastName: {record.Consumer.LastName}");
        Console.WriteLine($"\tMelissaIdentityKey: {record.Consumer.MelissaIdentityKey}");

        Console.WriteLine($"Phone:");
        Console.WriteLine($"\tPhone: {record.Phone.Phone}");
      }
    }

    public void PeopleBusinessSearchSetValueSample2()
    {
      PeopleBusinessSearch peopleBusiness = new PeopleBusinessSearch(licenseKey);
      peopleBusiness.MaxRecords = "10";
      peopleBusiness.MatchLevel = "10";
      peopleBusiness.AddressLine1 = "22382 Avenida Empresa";
      peopleBusiness.Locality = "RSM";
      peopleBusiness.AdministrativeArea = "CA";
      peopleBusiness.Postal = "92688";
      peopleBusiness.AnyName = "Melissa Data";

      string response = peopleBusiness.Get<string>();
      PeopleBusinessSearchResponse responseObject = peopleBusiness.Get<PeopleBusinessSearchResponse>();

      Console.WriteLine(response);

      Console.WriteLine($"TransmissionReference: {responseObject.TransmissionReference}");
      Console.WriteLine($"Version: {responseObject.Version}");
      Console.WriteLine($"ResultCode: {responseObject.ResultCode}");
      Console.WriteLine($"TotalRecords: {responseObject.TotalRecords}");
      foreach (var record in responseObject.Results)
      {
        Console.WriteLine($"\nMatchLevel: {record.MatchLevel}");

        Console.WriteLine($"Address:");
        Console.WriteLine($"\tAddress1: {record.Address.Address1}");
        Console.WriteLine($"\tLocality: {record.Address.Locality}");
        Console.WriteLine($"\tLocalityAlternates: {record.Address.LocalityAlternates}");
        Console.WriteLine($"\tAdministrativeArea: {record.Address.AdministrativeArea}");
        Console.WriteLine($"\tCountryCode: {record.Address.CountryCode}");
        Console.WriteLine($"\tCountryName: {record.Address.CountryName}");
        Console.WriteLine($"\tThoroughfare: {record.Address.Thoroughfare}");
        Console.WriteLine($"\tThoroughfareName: {record.Address.ThoroughfareName}");
        Console.WriteLine($"\tPremises: {record.Address.Premises}");
        Console.WriteLine($"\tPremiseNumber: {record.Address.PremiseNumber}");
        Console.WriteLine($"\tPostalCode: {record.Address.PostalCode}");
        Console.WriteLine($"\tPostalCodeSecondary: {record.Address.PostalCodeSecondary}");
        Console.WriteLine($"\tMelissaAddressKey: {record.Address.MelissaAddressKey}");

        Console.WriteLine($"Consumer:");
        Console.WriteLine($"\tFullname: {record.Consumer.FullName}");
        Console.WriteLine($"\tFirstName: {record.Consumer.FirstName}");
        Console.WriteLine($"\tLastName: {record.Consumer.LastName}");
        Console.WriteLine($"\tMelissaIdentityKey: {record.Consumer.MelissaIdentityKey}");

        Console.WriteLine($"Phone:");
        Console.WriteLine($"\tPhone: {record.Phone.Phone}");
      }
    }
  }
}
