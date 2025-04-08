using MelissaData.CloudAPI;

namespace MelissaCloudAPIDotnet.MelissaCloudAPISamples
{
  public class PersonatorIdentitySamples
  {
    public string licenseKey;

    public PersonatorIdentitySamples(string licenseKey)
    {
      this.licenseKey = licenseKey;
    }

    /// <summary>
    /// This function uses the Personator Identity Cloud API object to make a GET request
    /// </summary>
    public void PersonatorIdentitySample()
    {
      PersonatorIdentity personator = new PersonatorIdentity(licenseKey);
      personator.SetAction("check");
      personator.SetFullName("Raymond Melissa");
      personator.SetAddressLine1("22382 Avenida Empresa");
      personator.SetLocality("Rancho Santa Margarita");
      personator.SetAdministrativeArea("CA");
      personator.SetPostal("92688");
      personator.SetCountry("United States");

      string response = personator.Get<string>();
      PersonatorIdentityResponse responseObject = personator.Get<PersonatorIdentityResponse>();

      Console.WriteLine(response);

      Console.WriteLine($"\nTransactionID: {responseObject.TransactionID}");
      Console.WriteLine($"TransmissionReference: {responseObject.TransmissionReference}");
      Console.WriteLine($"Results: {responseObject.Results}");
      Console.WriteLine($"Version: {responseObject.Version}\n");

      Console.WriteLine("Name:");
      Console.WriteLine("\tResults: " + responseObject.Name.Results);
      Console.WriteLine("\tNameFirst: " + responseObject.Name.NameFirst);
      Console.WriteLine("\tNameLast: " + responseObject.Name.NameLast);
      Console.WriteLine("\tGender: " + responseObject.Name.Gender);

      Console.WriteLine("Address:");
      Console.WriteLine("\tResults: " + responseObject.Address.Results);
      Console.WriteLine("\tFormattedAddress: " + responseObject.Address.FormattedAddress);
      Console.WriteLine("\tAddressLine1: " + responseObject.Address.AddressLine1);
      Console.WriteLine("\tAddressLine2: " + responseObject.Address.AddressLine2);
      Console.WriteLine("\tLocality: " + responseObject.Address.Locality);
      Console.WriteLine("\tSubAdministrativeArea: " + responseObject.Address.SubAdministrativeArea);
      Console.WriteLine("\tAdministrativeArea: " + responseObject.Address.AdministrativeArea);
      Console.WriteLine("\tPostalCode: " + responseObject.Address.PostalCode);
      Console.WriteLine("\tAddressType: " + responseObject.Address.AddressType);
      Console.WriteLine("\tAddressKey: " + responseObject.Address.AddressKey);
      Console.WriteLine("\tCountryName: " + responseObject.Address.CountryName);
      Console.WriteLine("\tCountryCode: " + responseObject.Address.CountryCode);
      Console.WriteLine("\tCountryISO3: " + responseObject.Address.CountryISO3);
      Console.WriteLine("\tCountryNumber: " + responseObject.Address.CountryNumber);
      Console.WriteLine("\tCountrySubdivisionCode: " + responseObject.Address.CountrySubdivisionCode);
      Console.WriteLine("\tThoroughfare: " + responseObject.Address.Thoroughfare);
      Console.WriteLine("\tThoroughfareName: " + responseObject.Address.ThoroughfareName);
      Console.WriteLine("\tPremisesNumber: " + responseObject.Address.PremisesNumber);
      Console.WriteLine("\tLatitude: " + responseObject.Address.Latitude);
      Console.WriteLine("\tLongitude: " + responseObject.Address.Longitude);
    }

    /// <summary>
    /// This asynchronous function uses the Personator Identity Cloud API object to make a GET request
    /// </summary>
    public async Task PersonatorIdentityAsyncSample()
    {
      PersonatorIdentity personator = new PersonatorIdentity(licenseKey);
      personator.SetAction("check");
      personator.SetFullName("Raymond Melissa");
      personator.SetAddressLine1("22382 Avenida Empresa");
      personator.SetLocality("Rancho Santa Margarita");
      personator.SetAdministrativeArea("CA");
      personator.SetPostal("92688");
      personator.SetCountry("United States");

      string response = await personator.GetAsync<string>();
      PersonatorIdentityResponse responseObject = await personator.GetAsync<PersonatorIdentityResponse>();

      Console.WriteLine(response);

      Console.WriteLine($"\nTransactionID: {responseObject.TransactionID}");
      Console.WriteLine($"TransmissionReference: {responseObject.TransmissionReference}");
      Console.WriteLine($"Results: {responseObject.Results}");
      Console.WriteLine($"Version: {responseObject.Version}\n");

      Console.WriteLine("Name:");
      Console.WriteLine("\tResults: " + responseObject.Name.Results);
      Console.WriteLine("\tNameFirst: " + responseObject.Name.NameFirst);
      Console.WriteLine("\tNameLast: " + responseObject.Name.NameLast);
      Console.WriteLine("\tGender: " + responseObject.Name.Gender);

      Console.WriteLine("Address:");
      Console.WriteLine("\tResults: " + responseObject.Address.Results);
      Console.WriteLine("\tFormattedAddress: " + responseObject.Address.FormattedAddress);
      Console.WriteLine("\tAddressLine1: " + responseObject.Address.AddressLine1);
      Console.WriteLine("\tAddressLine2: " + responseObject.Address.AddressLine2);
      Console.WriteLine("\tLocality: " + responseObject.Address.Locality);
      Console.WriteLine("\tSubAdministrativeArea: " + responseObject.Address.SubAdministrativeArea);
      Console.WriteLine("\tAdministrativeArea: " + responseObject.Address.AdministrativeArea);
      Console.WriteLine("\tPostalCode: " + responseObject.Address.PostalCode);
      Console.WriteLine("\tAddressType: " + responseObject.Address.AddressType);
      Console.WriteLine("\tAddressKey: " + responseObject.Address.AddressKey);
      Console.WriteLine("\tCountryName: " + responseObject.Address.CountryName);
      Console.WriteLine("\tCountryCode: " + responseObject.Address.CountryCode);
      Console.WriteLine("\tCountryISO3: " + responseObject.Address.CountryISO3);
      Console.WriteLine("\tCountryNumber: " + responseObject.Address.CountryNumber);
      Console.WriteLine("\tCountrySubdivisionCode: " + responseObject.Address.CountrySubdivisionCode);
      Console.WriteLine("\tThoroughfare: " + responseObject.Address.Thoroughfare);
      Console.WriteLine("\tThoroughfareName: " + responseObject.Address.ThoroughfareName);
      Console.WriteLine("\tPremisesNumber: " + responseObject.Address.PremisesNumber);
      Console.WriteLine("\tLatitude: " + responseObject.Address.Latitude);
      Console.WriteLine("\tLongitude: " + responseObject.Address.Longitude);
    }

    /// <summary>
    /// This function uses the Personator Identity Cloud API object to make a POST request
    /// This function showcases setting and making POST requests: construct the POST body structure using the Cloud API's respective RecordRequest class
    /// </summary>
    public void PersonatorIdentityPostSample()
    {
      PersonatorIdentity personator = new PersonatorIdentity();
      personator.SetPostBody(new PersonatorIdentityRecordRequest
      {
        CustomerID = licenseKey,
        Actions = "check",
        FullName = "Raymond Melissa",
        AddressLine1 = "22382 Avenida Empresa",
        Locality = "Rancho Santa Margarita",
        AdministrativeArea = "CA",
        PostalCode = "92688",
        Country = "United States"
      });


      string response = personator.Post<string>();
      PersonatorIdentityResponse responseObject = personator.Post<PersonatorIdentityResponse>();

      Console.WriteLine(response);

      Console.WriteLine($"\nTransactionID: {responseObject.TransactionID}");
      Console.WriteLine($"TransmissionReference: {responseObject.TransmissionReference}");
      Console.WriteLine($"Results: {responseObject.Results}");
      Console.WriteLine($"Version: {responseObject.Version}\n");

      Console.WriteLine("Name:");
      Console.WriteLine("\tResults: " + responseObject.Name.Results);
      Console.WriteLine("\tNameFirst: " + responseObject.Name.NameFirst);
      Console.WriteLine("\tNameLast: " + responseObject.Name.NameLast);
      Console.WriteLine("\tGender: " + responseObject.Name.Gender);

      Console.WriteLine("Address:");
      Console.WriteLine("\tResults: " + responseObject.Address.Results);
      Console.WriteLine("\tFormattedAddress: " + responseObject.Address.FormattedAddress);
      Console.WriteLine("\tAddressLine1: " + responseObject.Address.AddressLine1);
      Console.WriteLine("\tAddressLine2: " + responseObject.Address.AddressLine2);
      Console.WriteLine("\tLocality: " + responseObject.Address.Locality);
      Console.WriteLine("\tSubAdministrativeArea: " + responseObject.Address.SubAdministrativeArea);
      Console.WriteLine("\tAdministrativeArea: " + responseObject.Address.AdministrativeArea);
      Console.WriteLine("\tPostalCode: " + responseObject.Address.PostalCode);
      Console.WriteLine("\tAddressType: " + responseObject.Address.AddressType);
      Console.WriteLine("\tAddressKey: " + responseObject.Address.AddressKey);
      Console.WriteLine("\tCountryName: " + responseObject.Address.CountryName);
      Console.WriteLine("\tCountryCode: " + responseObject.Address.CountryCode);
      Console.WriteLine("\tCountryISO3: " + responseObject.Address.CountryISO3);
      Console.WriteLine("\tCountryNumber: " + responseObject.Address.CountryNumber);
      Console.WriteLine("\tCountrySubdivisionCode: " + responseObject.Address.CountrySubdivisionCode);
      Console.WriteLine("\tThoroughfare: " + responseObject.Address.Thoroughfare);
      Console.WriteLine("\tThoroughfareName: " + responseObject.Address.ThoroughfareName);
      Console.WriteLine("\tPremisesNumber: " + responseObject.Address.PremisesNumber);
      Console.WriteLine("\tLatitude: " + responseObject.Address.Latitude);
      Console.WriteLine("\tLongitude: " + responseObject.Address.Longitude);
    }

    /// <summary>
    /// This asynchronous function uses the Personator Identity Cloud API object to make a POST request
    /// </summary>
    public async Task PersonatorIdentityPostAsyncSample()
    {
      PersonatorIdentity personator = new PersonatorIdentity();
      personator.SetPostBody(new PersonatorIdentityRecordRequest
      {
        CustomerID = licenseKey,
        Actions = "check",
        FullName = "Raymond Melissa",
        AddressLine1 = "22382 Avenida Empresa",
        Locality = "Rancho Santa Margarita",
        AdministrativeArea = "CA",
        PostalCode = "92688",
        Country = "United States"
      });


      string response = await personator.PostAsync<string>();
      PersonatorIdentityResponse responseObject = await personator.PostAsync<PersonatorIdentityResponse>();

      Console.WriteLine(response);

      Console.WriteLine($"\nTransactionID: {responseObject.TransactionID}");
      Console.WriteLine($"TransmissionReference: {responseObject.TransmissionReference}");
      Console.WriteLine($"Results: {responseObject.Results}");
      Console.WriteLine($"Version: {responseObject.Version}\n");

      Console.WriteLine("Name:");
      Console.WriteLine("\tResults: " + responseObject.Name.Results);
      Console.WriteLine("\tNameFirst: " + responseObject.Name.NameFirst);
      Console.WriteLine("\tNameLast: " + responseObject.Name.NameLast);
      Console.WriteLine("\tGender: " + responseObject.Name.Gender);

      Console.WriteLine("Address:");
      Console.WriteLine("\tResults: " + responseObject.Address.Results);
      Console.WriteLine("\tFormattedAddress: " + responseObject.Address.FormattedAddress);
      Console.WriteLine("\tAddressLine1: " + responseObject.Address.AddressLine1);
      Console.WriteLine("\tAddressLine2: " + responseObject.Address.AddressLine2);
      Console.WriteLine("\tLocality: " + responseObject.Address.Locality);
      Console.WriteLine("\tSubAdministrativeArea: " + responseObject.Address.SubAdministrativeArea);
      Console.WriteLine("\tAdministrativeArea: " + responseObject.Address.AdministrativeArea);
      Console.WriteLine("\tPostalCode: " + responseObject.Address.PostalCode);
      Console.WriteLine("\tAddressType: " + responseObject.Address.AddressType);
      Console.WriteLine("\tAddressKey: " + responseObject.Address.AddressKey);
      Console.WriteLine("\tCountryName: " + responseObject.Address.CountryName);
      Console.WriteLine("\tCountryCode: " + responseObject.Address.CountryCode);
      Console.WriteLine("\tCountryISO3: " + responseObject.Address.CountryISO3);
      Console.WriteLine("\tCountryNumber: " + responseObject.Address.CountryNumber);
      Console.WriteLine("\tCountrySubdivisionCode: " + responseObject.Address.CountrySubdivisionCode);
      Console.WriteLine("\tThoroughfare: " + responseObject.Address.Thoroughfare);
      Console.WriteLine("\tThoroughfareName: " + responseObject.Address.ThoroughfareName);
      Console.WriteLine("\tPremisesNumber: " + responseObject.Address.PremisesNumber);
      Console.WriteLine("\tLatitude: " + responseObject.Address.Latitude);
      Console.WriteLine("\tLongitude: " + responseObject.Address.Longitude);
    }

    public void PersonatorIdentitySetValueSample()
    {
      PersonatorIdentity personator = new PersonatorIdentity(licenseKey);

      personator.SetValue("Action", "check");
      personator.SetValue("FullName", "Raymond Melissa");
      personator.SetValue("AddressLine1", "22382 Avenida Empresa");
      personator.SetValue("Locality", "Rancho Santa Margarita");
      personator.SetValue("AdministrativeArea", "CA");
      personator.SetValue("Postal", "92688");
      personator.SetValue("Country", "United States");

      string response = personator.Get<string>();
      PersonatorIdentityResponse responseObject = personator.Get<PersonatorIdentityResponse>();

      Console.WriteLine(response);

      Console.WriteLine($"\nTransactionID: {responseObject.TransactionID}");
      Console.WriteLine($"TransmissionReference: {responseObject.TransmissionReference}");
      Console.WriteLine($"Results: {responseObject.Results}");
      Console.WriteLine($"Version: {responseObject.Version}\n");

      Console.WriteLine("Name:");
      Console.WriteLine("\tResults: " + responseObject.Name.Results);
      Console.WriteLine("\tNameFirst: " + responseObject.Name.NameFirst);
      Console.WriteLine("\tNameLast: " + responseObject.Name.NameLast);
      Console.WriteLine("\tGender: " + responseObject.Name.Gender);

      Console.WriteLine("Address:");
      Console.WriteLine("\tResults: " + responseObject.Address.Results);
      Console.WriteLine("\tFormattedAddress: " + responseObject.Address.FormattedAddress);
      Console.WriteLine("\tAddressLine1: " + responseObject.Address.AddressLine1);
      Console.WriteLine("\tAddressLine2: " + responseObject.Address.AddressLine2);
      Console.WriteLine("\tLocality: " + responseObject.Address.Locality);
      Console.WriteLine("\tSubAdministrativeArea: " + responseObject.Address.SubAdministrativeArea);
      Console.WriteLine("\tAdministrativeArea: " + responseObject.Address.AdministrativeArea);
      Console.WriteLine("\tPostalCode: " + responseObject.Address.PostalCode);
      Console.WriteLine("\tAddressType: " + responseObject.Address.AddressType);
      Console.WriteLine("\tAddressKey: " + responseObject.Address.AddressKey);
      Console.WriteLine("\tCountryName: " + responseObject.Address.CountryName);
      Console.WriteLine("\tCountryCode: " + responseObject.Address.CountryCode);
      Console.WriteLine("\tCountryISO3: " + responseObject.Address.CountryISO3);
      Console.WriteLine("\tCountryNumber: " + responseObject.Address.CountryNumber);
      Console.WriteLine("\tCountrySubdivisionCode: " + responseObject.Address.CountrySubdivisionCode);
      Console.WriteLine("\tThoroughfare: " + responseObject.Address.Thoroughfare);
      Console.WriteLine("\tThoroughfareName: " + responseObject.Address.ThoroughfareName);
      Console.WriteLine("\tPremisesNumber: " + responseObject.Address.PremisesNumber);
      Console.WriteLine("\tLatitude: " + responseObject.Address.Latitude);
      Console.WriteLine("\tLongitude: " + responseObject.Address.Longitude);
    }

    public void PersonatorIdentitySetValueSample2()
    {
      PersonatorIdentity personator = new PersonatorIdentity(licenseKey);

      personator.Action = "check";
      personator.FullName = "Raymond Melissa";
      personator.AddressLine1 = "22382 Avenida Empresa";
      personator.Locality = "Rancho Santa Margarita";
      personator.AdministrativeArea = "CA";
      personator.Postal = "92688";
      personator.Country = "United States";

      string response = personator.Get<string>();
      PersonatorIdentityResponse responseObject = personator.Get<PersonatorIdentityResponse>();

      Console.WriteLine(response);

      Console.WriteLine($"\nTransactionID: {responseObject.TransactionID}");
      Console.WriteLine($"TransmissionReference: {responseObject.TransmissionReference}");
      Console.WriteLine($"Results: {responseObject.Results}");
      Console.WriteLine($"Version: {responseObject.Version}\n");

      Console.WriteLine("Name:");
      Console.WriteLine("\tResults: " + responseObject.Name.Results);
      Console.WriteLine("\tNameFirst: " + responseObject.Name.NameFirst);
      Console.WriteLine("\tNameLast: " + responseObject.Name.NameLast);
      Console.WriteLine("\tGender: " + responseObject.Name.Gender);

      Console.WriteLine("Address:");
      Console.WriteLine("\tResults: " + responseObject.Address.Results);
      Console.WriteLine("\tFormattedAddress: " + responseObject.Address.FormattedAddress);
      Console.WriteLine("\tAddressLine1: " + responseObject.Address.AddressLine1);
      Console.WriteLine("\tAddressLine2: " + responseObject.Address.AddressLine2);
      Console.WriteLine("\tLocality: " + responseObject.Address.Locality);
      Console.WriteLine("\tSubAdministrativeArea: " + responseObject.Address.SubAdministrativeArea);
      Console.WriteLine("\tAdministrativeArea: " + responseObject.Address.AdministrativeArea);
      Console.WriteLine("\tPostalCode: " + responseObject.Address.PostalCode);
      Console.WriteLine("\tAddressType: " + responseObject.Address.AddressType);
      Console.WriteLine("\tAddressKey: " + responseObject.Address.AddressKey);
      Console.WriteLine("\tCountryName: " + responseObject.Address.CountryName);
      Console.WriteLine("\tCountryCode: " + responseObject.Address.CountryCode);
      Console.WriteLine("\tCountryISO3: " + responseObject.Address.CountryISO3);
      Console.WriteLine("\tCountryNumber: " + responseObject.Address.CountryNumber);
      Console.WriteLine("\tCountrySubdivisionCode: " + responseObject.Address.CountrySubdivisionCode);
      Console.WriteLine("\tThoroughfare: " + responseObject.Address.Thoroughfare);
      Console.WriteLine("\tThoroughfareName: " + responseObject.Address.ThoroughfareName);
      Console.WriteLine("\tPremisesNumber: " + responseObject.Address.PremisesNumber);
      Console.WriteLine("\tLatitude: " + responseObject.Address.Latitude);
      Console.WriteLine("\tLongitude: " + responseObject.Address.Longitude);
    }
  }
}
