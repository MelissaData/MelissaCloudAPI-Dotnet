using MelissaData.CloudAPI;

namespace MelissaCloudAPIDotnet.MelissaCloudAPISamples
{
  public class GlobalExpressEntrySamples
  {
    public string licenseKey;

    public GlobalExpressEntrySamples(string licenseKey)
    {
      this.licenseKey = licenseKey;
    }

    /// <summary>
    /// This function uses the Global Express Entry Cloud API object to make a GET request
    /// Multiple endpoints are tested
    /// </summary>
    public void GlobalExpressEntrySample()
    {
      GlobalExpressEntry globalExpressEntry = new GlobalExpressEntry(licenseKey);
      globalExpressEntry.SetAddressLine1("22382 Avenida Empresa");
      globalExpressEntry.SetCity("RSM");
      globalExpressEntry.SetState("CA");
      globalExpressEntry.SetPostal("92688");

      string response = globalExpressEntry.GetExpressAddress<string>();
      ExpressEntryResponse responseObject = globalExpressEntry.GetExpressAddress<ExpressEntryResponse>();

      Console.WriteLine(response);

      Console.WriteLine($"\nVersion: {responseObject.Version}");
      Console.WriteLine($"ResultCode: {responseObject.ResultCode}");
      Console.WriteLine($"ErrorString: {responseObject.ErrorString}\n");
      foreach (var record in responseObject.Results)
      {
        Console.WriteLine($"Address: \n" +
          $"  AddressLine1: {record.Address.AddressLine1}\n" +
          $"  City: {record.Address.City}\n" +
          $"  CityAccepted: {record.Address.CityAccepted}\n" +
          $"  State: {record.Address.State}\n" +
          $"  PostalCode: {record.Address.PostalCode}\n" +
          $"  CountrySubdivisionCode: {record.Address.CountrySubdivisionCode}\n" +
          $"  AddressKey: {record.Address.AddressKey}\n" +
          $"  SuiteCount: {record.Address.SuiteCount}\n" +
          $"  Plus4: {record.Address.PlusFour[0]}\n" +
          $"  MAK: {record.Address.MAK}\n");
      }

      globalExpressEntry.Clear();

      globalExpressEntry.SetCity("RSM");
      globalExpressEntry.SetState("CA");

      response = globalExpressEntry.GetExpressCityState<string>();
      responseObject = globalExpressEntry.GetExpressCityState<ExpressEntryResponse>();

      Console.WriteLine(response);

      Console.WriteLine($"\nVersion: {responseObject.Version}");
      Console.WriteLine($"ResultCode: {responseObject.ResultCode}");
      Console.WriteLine($"ErrorString: {responseObject.ErrorString}\n");
      foreach (var record in responseObject.Results)
      {
        Console.WriteLine($"Address: \n" +
          $"  City: {record.Address.City}\n" +
          $"  CityAccepted: {record.Address.CityAccepted}\n" +
          $"  State: {record.Address.State}\n" +
          $"  PostalCode: {record.Address.PostalCode}\n" +
          $"  CountrySubdivisionCode: {record.Address.CountrySubdivisionCode}\n" +
          $"  SuiteCount: {record.Address.SuiteCount}\n");
      }

      globalExpressEntry.Clear();

      globalExpressEntry.SetPostal("92688");

      response = globalExpressEntry.GetExpressPostalCode<string>();
      responseObject = globalExpressEntry.GetExpressPostalCode<ExpressEntryResponse>();

      Console.WriteLine(response);

      Console.WriteLine($"\nVersion: {responseObject.Version}");
      Console.WriteLine($"ResultCode: {responseObject.ResultCode}");
      Console.WriteLine($"ErrorString: {responseObject.ErrorString}\n");
      foreach (var record in responseObject.Results)
      {
        Console.WriteLine($"Address: \n" +
          $"  City: {record.Address.City}\n" +
          $"  CityAccepted: {record.Address.CityAccepted}\n" +
          $"  State: {record.Address.State}\n" +
          $"  PostalCode: {record.Address.PostalCode}\n" +
          $"  CountrySubdivisionCode: {record.Address.CountrySubdivisionCode}\n" +
          $"  SuiteCount: {record.Address.SuiteCount}\n");
      }

      globalExpressEntry.Clear();

      globalExpressEntry.SetAddressLine1("Avenida");
      globalExpressEntry.SetPostal("92688");

      response = globalExpressEntry.GetExpressStreet<string>();
      responseObject = globalExpressEntry.GetExpressStreet<ExpressEntryResponse>();

      Console.WriteLine(response);

      Console.WriteLine($"\nVersion: {responseObject.Version}");
      Console.WriteLine($"ResultCode: {responseObject.ResultCode}");
      Console.WriteLine($"ErrorString: {responseObject.ErrorString}\n");
      foreach (var record in responseObject.Results)
      {
        Console.WriteLine($"Address: \n" +
          $"  AddressLine1: {record.Address.AddressLine1}\n" +
          $"  City: {record.Address.City}\n" +
          $"  CityAccepted: {record.Address.CityAccepted}\n" +
          $"  State: {record.Address.State}\n" +
          $"  PostalCode: {record.Address.PostalCode}\n" +
          $"  CountrySubdivisionCode: {record.Address.CountrySubdivisionCode}\n" +
          $"  SuiteCount: {record.Address.SuiteCount}\n");
      }

      globalExpressEntry.Clear();

      globalExpressEntry.SetAddressLine1("Avenida Empresa, Rancho Santa Margarita, CA");
      globalExpressEntry.SetLocality("Rancho Santa Margarita");
      globalExpressEntry.SetAdministrativeArea("CA");
      globalExpressEntry.SetPostal("92688");
      globalExpressEntry.SetCountry("United States");
      globalExpressEntry.SetMaxRecords("2");

      response = globalExpressEntry.GetGlobalExpressAddress<string>();
      GlobalExpressEntryResponse globalResponseObject = globalExpressEntry.GetGlobalExpressAddress<GlobalExpressEntryResponse>();

      Console.WriteLine(response);

      Console.WriteLine($"\nVersion: {globalResponseObject.Version}");
      Console.WriteLine($"ResultCode: {globalResponseObject.ResultCode}");
      Console.WriteLine($"ErrorString: {globalResponseObject.ErrorString}\n");

      foreach (var record in globalResponseObject.Results)
      {
        Console.WriteLine($"Address: \n" +
          $"  Address: {record.Address.Address}\n" +
          $"  Address1: {record.Address.Address1}\n" +
          $"  Address2: {record.Address.Address2}\n" +
          $"  DeliveryAddress: {record.Address.DeliveryAddress}\n" +
          $"  DeliveryAddress1: {record.Address.DeliveryAddress1}\n" +
          $"  CountryName: {record.Address.CountryName}\n" +
          $"  ISO3166_2: {record.Address.ISO3166_2}\n" +
          $"  ISO3166_3: {record.Address.ISO3166_3}\n" +
          $"  ISO3166_N: {record.Address.ISO3166_N}\n" +
          $"  AdministrativeArea: {record.Address.AdministrativeArea}\n" +
          $"  SubAdministrativeArea: {record.Address.SubAdministrativeArea}\n" +
          $"  Locality: {record.Address.Locality}\n" +
          $"  CityAccepted: {record.Address.CityAccepted}\n" +
          $"  Thoroughfare: {record.Address.Thoroughfare}\n" +
          $"  Premise: {record.Address.Premise}\n" +
          $"  SubBuilding: {record.Address.SubBuilding}\n" +
          $"  PostalCode: {record.Address.PostalCode}\n" +
          $"  PostalCodePrimary: {record.Address.PostalCodePrimary}\n" +
          $"  PostalCodeSecondary: {record.Address.PostalCodeSecondary}\n" +
          $"  CountrySubdivisionCode: {record.Address.CountrySubdivisionCode}\n" +
          $"  MAK: {record.Address.MAK}\n" +
          $"  BaseMAK: {record.Address.BaseMAK}\n" +
          $"  DistanceFromPoint: {record.Address.DistanceFromPoint}\n");
      }

      globalExpressEntry.Clear();

      globalExpressEntry.SetCountry("France");

      response = globalExpressEntry.GetGlobalExpressCountry<string>();
      globalResponseObject = globalExpressEntry.GetGlobalExpressCountry<GlobalExpressEntryResponse>();

      Console.WriteLine(response);

      Console.WriteLine($"\nVersion: {globalResponseObject.Version}");
      Console.WriteLine($"ResultCode: {globalResponseObject.ResultCode}");
      Console.WriteLine($"ErrorString: {globalResponseObject.ErrorString}\n");
      foreach (var record in globalResponseObject.Results)
      {
        Console.WriteLine($"Address: \n" +
          $"  Country: {record.Country}\n" +
          $"  English: {record.English}\n" +
          $"  Spanish: {record.Spanish}\n" +
          $"  French: {record.French}\n" +
          $"  German: {record.German}\n" +
          $"  SimplifiedChinese: {record.SimplifiedChinese}\n" +
          $"  Char2ISO: {record.Char2ISO}\n" +
          $"  Char3ISO: {record.Char3ISO}\n" +
          $"  ISONumeric: {record.ISONumeric}\n");
      }

      globalExpressEntry.Clear();

      globalExpressEntry.SetFreeForm("22382 Avenida Empresa, RSM, CA, 92688");
      globalExpressEntry.SetCountry("United States");

      response = globalExpressEntry.GetGlobalExpressFreeForm<string>();
      globalResponseObject = globalExpressEntry.GetGlobalExpressFreeForm<GlobalExpressEntryResponse>();

      Console.WriteLine(response);

      Console.WriteLine($"\nVersion: {globalResponseObject.Version}");
      Console.WriteLine($"ResultCode: {globalResponseObject.ResultCode}");
      Console.WriteLine($"ErrorString: {globalResponseObject.ErrorString}\n");
      foreach (var record in globalResponseObject.Results)
      {
        Console.WriteLine($"Address: \n" +
          $"  Address: {record.Address.Address}\n" +
          $"  Address1: {record.Address.Address1}\n" +
          $"  Address2: {record.Address.Address2}\n" +
          $"  DeliveryAddress: {record.Address.DeliveryAddress}\n" +
          $"  DeliveryAddress1: {record.Address.DeliveryAddress1}\n" +
          $"  CountryName: {record.Address.CountryName}\n" +
          $"  ISO3166_2: {record.Address.ISO3166_2}\n" +
          $"  ISO3166_3: {record.Address.ISO3166_3}\n" +
          $"  ISO3166_N: {record.Address.ISO3166_N}\n" +
          $"  AdministrativeArea: {record.Address.AdministrativeArea}\n" +
          $"  SubAdministrativeArea: {record.Address.SubAdministrativeArea}\n" +
          $"  Locality: {record.Address.Locality}\n" +
          $"  CityAccepted: {record.Address.CityAccepted}\n" +
          $"  Thoroughfare: {record.Address.Thoroughfare}\n" +
          $"  Premise: {record.Address.Premise}\n" +
          $"  SubBuilding: {record.Address.SubBuilding}\n" +
          $"  PostalCode: {record.Address.PostalCode}\n" +
          $"  PostalCodePrimary: {record.Address.PostalCodePrimary}\n" +
          $"  PostalCodeSecondary: {record.Address.PostalCodeSecondary}\n" +
          $"  CountrySubdivisionCode: {record.Address.CountrySubdivisionCode}\n" +
          $"  MAK: {record.Address.MAK}\n" +
          $"  BaseMAK: {record.Address.BaseMAK}\n" +
          $"  DistanceFromPoint: {record.Address.DistanceFromPoint}\n");
      }

      globalExpressEntry.Clear();

      globalExpressEntry.SetPostal("92688");
      globalExpressEntry.SetCountry("United States");

      response = globalExpressEntry.GetGlobalExpressPostalCode<string>();
      globalResponseObject = globalExpressEntry.GetGlobalExpressPostalCode<GlobalExpressEntryResponse>();

      Console.WriteLine(response);

      Console.WriteLine($"\nVersion: {globalResponseObject.Version}");
      Console.WriteLine($"ResultCode: {globalResponseObject.ResultCode}");
      Console.WriteLine($"ErrorString: {globalResponseObject.ErrorString}\n");
      foreach (var record in globalResponseObject.Results)
      {
        Console.WriteLine($"Address: \n" +
          $"  Address: {record.Address.Address}\n" +
          $"  Address1: {record.Address.Address1}\n" +
          $"  Address2: {record.Address.Address2}\n" +
          $"  DeliveryAddress: {record.Address.DeliveryAddress}\n" +
          $"  DeliveryAddress1: {record.Address.DeliveryAddress1}\n" +
          $"  CountryName: {record.Address.CountryName}\n" +
          $"  ISO3166_2: {record.Address.ISO3166_2}\n" +
          $"  ISO3166_3: {record.Address.ISO3166_3}\n" +
          $"  ISO3166_N: {record.Address.ISO3166_N}\n" +
          $"  AdministrativeArea: {record.Address.AdministrativeArea}\n" +
          $"  SubAdministrativeArea: {record.Address.SubAdministrativeArea}\n" +
          $"  Locality: {record.Address.Locality}\n" +
          $"  CityAccepted: {record.Address.CityAccepted}\n" +
          $"  Thoroughfare: {record.Address.Thoroughfare}\n" +
          $"  Premise: {record.Address.Premise}\n" +
          $"  SubBuilding: {record.Address.SubBuilding}\n" +
          $"  PostalCode: {record.Address.PostalCode}\n" +
          $"  PostalCodePrimary: {record.Address.PostalCodePrimary}\n" +
          $"  PostalCodeSecondary: {record.Address.PostalCodeSecondary}\n" +
          $"  CountrySubdivisionCode: {record.Address.CountrySubdivisionCode}\n" +
          $"  MAK: {record.Address.MAK}\n" +
          $"  BaseMAK: {record.Address.BaseMAK}\n" +
          $"  DistanceFromPoint: {record.Address.DistanceFromPoint}\n");
      }

      globalExpressEntry.Clear();


      globalExpressEntry.SetThoroughfare("avenida empresa");
      globalExpressEntry.SetPostal("92688");
      globalExpressEntry.SetCountry("united states");

      response = globalExpressEntry.GetGlobalExpressThoroughfare<string>();
      globalResponseObject = globalExpressEntry.GetGlobalExpressThoroughfare<GlobalExpressEntryResponse>();

      Console.WriteLine(response);

      Console.WriteLine($"\nVersion: {globalResponseObject.Version}");
      Console.WriteLine($"ResultCode: {globalResponseObject.ResultCode}");
      Console.WriteLine($"ErrorString: {globalResponseObject.ErrorString}\n");
      foreach (var record in globalResponseObject.Results)
      {
        Console.WriteLine($"Address: \n" +
          $"  Address: {record.Address.Address}\n" +
          $"  Address1: {record.Address.Address1}\n" +
          $"  Address2: {record.Address.Address2}\n" +
          $"  DeliveryAddress: {record.Address.DeliveryAddress}\n" +
          $"  DeliveryAddress1: {record.Address.DeliveryAddress1}\n" +
          $"  CountryName: {record.Address.CountryName}\n" +
          $"  ISO3166_2: {record.Address.ISO3166_2}\n" +
          $"  ISO3166_3: {record.Address.ISO3166_3}\n" +
          $"  ISO3166_N: {record.Address.ISO3166_N}\n" +
          $"  AdministrativeArea: {record.Address.AdministrativeArea}\n" +
          $"  SubAdministrativeArea: {record.Address.SubAdministrativeArea}\n" +
          $"  Locality: {record.Address.Locality}\n" +
          $"  CityAccepted: {record.Address.CityAccepted}\n" +
          $"  Thoroughfare: {record.Address.Thoroughfare}\n" +
          $"  Premise: {record.Address.Premise}\n" +
          $"  SubBuilding: {record.Address.SubBuilding}\n" +
          $"  PostalCode: {record.Address.PostalCode}\n" +
          $"  PostalCodePrimary: {record.Address.PostalCodePrimary}\n" +
          $"  PostalCodeSecondary: {record.Address.PostalCodeSecondary}\n" +
          $"  CountrySubdivisionCode: {record.Address.CountrySubdivisionCode}\n" +
          $"  MAK: {record.Address.MAK}\n" +
          $"  BaseMAK: {record.Address.BaseMAK}\n" +
          $"  DistanceFromPoint: {record.Address.DistanceFromPoint}\n");
      }
    }

    /// <summary>
    /// This asynchronous function uses the Global Express Entry Cloud API object to make a GET request
    /// Multiple endpoints are tested
    /// </summary>
    public async Task GlobalExpressEntryAsyncSample()
    {
      GlobalExpressEntry globalExpressEntry = new GlobalExpressEntry(licenseKey);
      globalExpressEntry.SetAddressLine1("22382 Avenida Empresa");
      globalExpressEntry.SetCity("RSM");
      globalExpressEntry.SetState("CA");
      globalExpressEntry.SetPostal("92688");

      string response = await globalExpressEntry.GetExpressAddressAsync<string>();
      ExpressEntryResponse responseObject = await globalExpressEntry.GetExpressAddressAsync<ExpressEntryResponse>();

      Console.WriteLine(response);

      Console.WriteLine($"\nVersion: {responseObject.Version}");
      Console.WriteLine($"ResultCode: {responseObject.ResultCode}");
      Console.WriteLine($"ErrorString: {responseObject.ErrorString}\n");
      foreach (var record in responseObject.Results)
      {
        Console.WriteLine($"Address: \n" +
          $"  AddressLine1: {record.Address.AddressLine1}\n" +
          $"  City: {record.Address.City}\n" +
          $"  CityAccepted: {record.Address.CityAccepted}\n" +
          $"  State: {record.Address.State}\n" +
          $"  PostalCode: {record.Address.PostalCode}\n" +
          $"  CountrySubdivisionCode: {record.Address.CountrySubdivisionCode}\n" +
          $"  AddressKey: {record.Address.AddressKey}\n" +
          $"  SuiteCount: {record.Address.SuiteCount}\n" +
          $"  Plus4: {record.Address.PlusFour[0]}\n" +
          $"  MAK: {record.Address.MAK}\n");
      }

      globalExpressEntry.Clear();

      globalExpressEntry.SetCity("RSM");
      globalExpressEntry.SetState("CA");

      response = await globalExpressEntry.GetExpressCityStateAsync<string>();
      responseObject = await globalExpressEntry.GetExpressCityStateAsync<ExpressEntryResponse>();

      Console.WriteLine(response);

      Console.WriteLine($"\nVersion: {responseObject.Version}");
      Console.WriteLine($"ResultCode: {responseObject.ResultCode}");
      Console.WriteLine($"ErrorString: {responseObject.ErrorString}\n");
      foreach (var record in responseObject.Results)
      {
        Console.WriteLine($"Address: \n" +
          $"  City: {record.Address.City}\n" +
          $"  CityAccepted: {record.Address.CityAccepted}\n" +
          $"  State: {record.Address.State}\n" +
          $"  PostalCode: {record.Address.PostalCode}\n" +
          $"  CountrySubdivisionCode: {record.Address.CountrySubdivisionCode}\n" +
          $"  SuiteCount: {record.Address.SuiteCount}\n");
      }

      globalExpressEntry.Clear();

      globalExpressEntry.SetPostal("92688");

      response = await globalExpressEntry.GetExpressPostalCodeAsync<string>();
      responseObject = await globalExpressEntry.GetExpressPostalCodeAsync<ExpressEntryResponse>();

      Console.WriteLine(response);

      Console.WriteLine($"\nVersion: {responseObject.Version}");
      Console.WriteLine($"ResultCode: {responseObject.ResultCode}");
      Console.WriteLine($"ErrorString: {responseObject.ErrorString}\n");
      foreach (var record in responseObject.Results)
      {
        Console.WriteLine($"Address: \n" +
          $"  City: {record.Address.City}\n" +
          $"  CityAccepted: {record.Address.CityAccepted}\n" +
          $"  State: {record.Address.State}\n" +
          $"  PostalCode: {record.Address.PostalCode}\n" +
          $"  CountrySubdivisionCode: {record.Address.CountrySubdivisionCode}\n" +
          $"  SuiteCount: {record.Address.SuiteCount}\n");
      }

      globalExpressEntry.Clear();

      globalExpressEntry.SetAddressLine1("Avenida");
      globalExpressEntry.SetPostal("92688");

      response = await globalExpressEntry.GetExpressStreetAsync<string>();
      responseObject = await globalExpressEntry.GetExpressStreetAsync<ExpressEntryResponse>();

      Console.WriteLine(response);

      Console.WriteLine($"\nVersion: {responseObject.Version}");
      Console.WriteLine($"ResultCode: {responseObject.ResultCode}");
      Console.WriteLine($"ErrorString: {responseObject.ErrorString}\n");
      foreach (var record in responseObject.Results)
      {
        Console.WriteLine($"Address: \n" +
          $"  AddressLine1: {record.Address.AddressLine1}\n" +
          $"  City: {record.Address.City}\n" +
          $"  CityAccepted: {record.Address.CityAccepted}\n" +
          $"  State: {record.Address.State}\n" +
          $"  PostalCode: {record.Address.PostalCode}\n" +
          $"  CountrySubdivisionCode: {record.Address.CountrySubdivisionCode}\n" +
          $"  SuiteCount: {record.Address.SuiteCount}\n");
      }

      globalExpressEntry.Clear();

      globalExpressEntry.SetAddressLine1("Avenida Empresa, Rancho Santa Margarita, CA");
      globalExpressEntry.SetLocality("Rancho Santa Margarita");
      globalExpressEntry.SetAdministrativeArea("CA");
      globalExpressEntry.SetPostal("92688");
      globalExpressEntry.SetCountry("United States");
      globalExpressEntry.SetMaxRecords("2");

      response = await globalExpressEntry.GetGlobalExpressAddressAsync<string>();
      GlobalExpressEntryResponse globalResponseObject = await globalExpressEntry.GetGlobalExpressAddressAsync<GlobalExpressEntryResponse>();

      Console.WriteLine(response);

      Console.WriteLine($"\nVersion: {globalResponseObject.Version}");
      Console.WriteLine($"ResultCode: {globalResponseObject.ResultCode}");
      Console.WriteLine($"ErrorString: {globalResponseObject.ErrorString}\n");

      foreach (var record in globalResponseObject.Results)
      {
        Console.WriteLine($"Address: \n" +
          $"  Address: {record.Address.Address}\n" +
          $"  Address1: {record.Address.Address1}\n" +
          $"  Address2: {record.Address.Address2}\n" +
          $"  DeliveryAddress: {record.Address.DeliveryAddress}\n" +
          $"  DeliveryAddress1: {record.Address.DeliveryAddress1}\n" +
          $"  CountryName: {record.Address.CountryName}\n" +
          $"  ISO3166_2: {record.Address.ISO3166_2}\n" +
          $"  ISO3166_3: {record.Address.ISO3166_3}\n" +
          $"  ISO3166_N: {record.Address.ISO3166_N}\n" +
          $"  AdministrativeArea: {record.Address.AdministrativeArea}\n" +
          $"  SubAdministrativeArea: {record.Address.SubAdministrativeArea}\n" +
          $"  Locality: {record.Address.Locality}\n" +
          $"  CityAccepted: {record.Address.CityAccepted}\n" +
          $"  Thoroughfare: {record.Address.Thoroughfare}\n" +
          $"  Premise: {record.Address.Premise}\n" +
          $"  SubBuilding: {record.Address.SubBuilding}\n" +
          $"  PostalCode: {record.Address.PostalCode}\n" +
          $"  PostalCodePrimary: {record.Address.PostalCodePrimary}\n" +
          $"  PostalCodeSecondary: {record.Address.PostalCodeSecondary}\n" +
          $"  CountrySubdivisionCode: {record.Address.CountrySubdivisionCode}\n" +
          $"  MAK: {record.Address.MAK}\n" +
          $"  BaseMAK: {record.Address.BaseMAK}\n" +
          $"  DistanceFromPoint: {record.Address.DistanceFromPoint}\n");
      }

      globalExpressEntry.Clear();

      globalExpressEntry.SetCountry("France");

      response = await globalExpressEntry.GetGlobalExpressCountryAsync<string>();
      globalResponseObject = await globalExpressEntry.GetGlobalExpressCountryAsync<GlobalExpressEntryResponse>();

      Console.WriteLine(response);

      Console.WriteLine($"\nVersion: {globalResponseObject.Version}");
      Console.WriteLine($"ResultCode: {globalResponseObject.ResultCode}");
      Console.WriteLine($"ErrorString: {globalResponseObject.ErrorString}\n");
      foreach (var record in globalResponseObject.Results)
      {
        Console.WriteLine($"Address: \n" +
          $"  Country: {record.Country}\n" +
          $"  English: {record.English}\n" +
          $"  Spanish: {record.Spanish}\n" +
          $"  French: {record.French}\n" +
          $"  German: {record.German}\n" +
          $"  SimplifiedChinese: {record.SimplifiedChinese}\n" +
          $"  Char2ISO: {record.Char2ISO}\n" +
          $"  Char3ISO: {record.Char3ISO}\n" +
          $"  ISONumeric: {record.ISONumeric}\n");
      }

      globalExpressEntry.Clear();

      globalExpressEntry.SetFreeForm("22382 Avenida Empresa, RSM, CA 92688");
      globalExpressEntry.SetCountry("United States");

      response = await globalExpressEntry.GetGlobalExpressFreeFormAsync<string>();
      globalResponseObject = await globalExpressEntry.GetGlobalExpressFreeFormAsync<GlobalExpressEntryResponse>();

      Console.WriteLine(response);

      Console.WriteLine($"\nVersion: {globalResponseObject.Version}");
      Console.WriteLine($"ResultCode: {globalResponseObject.ResultCode}");
      Console.WriteLine($"ErrorString: {globalResponseObject.ErrorString}\n");
      foreach (var record in globalResponseObject.Results)
      {
        Console.WriteLine($"Address: \n" +
          $"  Address: {record.Address.Address}\n" +
          $"  Address1: {record.Address.Address1}\n" +
          $"  Address2: {record.Address.Address2}\n" +
          $"  DeliveryAddress: {record.Address.DeliveryAddress}\n" +
          $"  DeliveryAddress1: {record.Address.DeliveryAddress1}\n" +
          $"  CountryName: {record.Address.CountryName}\n" +
          $"  ISO3166_2: {record.Address.ISO3166_2}\n" +
          $"  ISO3166_3: {record.Address.ISO3166_3}\n" +
          $"  ISO3166_N: {record.Address.ISO3166_N}\n" +
          $"  AdministrativeArea: {record.Address.AdministrativeArea}\n" +
          $"  SubAdministrativeArea: {record.Address.SubAdministrativeArea}\n" +
          $"  Locality: {record.Address.Locality}\n" +
          $"  CityAccepted: {record.Address.CityAccepted}\n" +
          $"  Thoroughfare: {record.Address.Thoroughfare}\n" +
          $"  Premise: {record.Address.Premise}\n" +
          $"  SubBuilding: {record.Address.SubBuilding}\n" +
          $"  PostalCode: {record.Address.PostalCode}\n" +
          $"  PostalCodePrimary: {record.Address.PostalCodePrimary}\n" +
          $"  PostalCodeSecondary: {record.Address.PostalCodeSecondary}\n" +
          $"  CountrySubdivisionCode: {record.Address.CountrySubdivisionCode}\n" +
          $"  MAK: {record.Address.MAK}\n" +
          $"  BaseMAK: {record.Address.BaseMAK}\n" +
          $"  DistanceFromPoint: {record.Address.DistanceFromPoint}\n");
      }

      globalExpressEntry.Clear();

      globalExpressEntry.SetPostal("92688");
      globalExpressEntry.SetCountry("United States");

      response = await globalExpressEntry.GetGlobalExpressPostalCodeAsync<string>();
      globalResponseObject = await globalExpressEntry.GetGlobalExpressPostalCodeAsync<GlobalExpressEntryResponse>();

      Console.WriteLine(response);

      Console.WriteLine($"\nVersion: {globalResponseObject.Version}");
      Console.WriteLine($"ResultCode: {globalResponseObject.ResultCode}");
      Console.WriteLine($"ErrorString: {globalResponseObject.ErrorString}\n");
      foreach (var record in globalResponseObject.Results)
      {
        Console.WriteLine($"Address: \n" +
          $"  Address: {record.Address.Address}\n" +
          $"  Address1: {record.Address.Address1}\n" +
          $"  Address2: {record.Address.Address2}\n" +
          $"  DeliveryAddress: {record.Address.DeliveryAddress}\n" +
          $"  DeliveryAddress1: {record.Address.DeliveryAddress1}\n" +
          $"  CountryName: {record.Address.CountryName}\n" +
          $"  ISO3166_2: {record.Address.ISO3166_2}\n" +
          $"  ISO3166_3: {record.Address.ISO3166_3}\n" +
          $"  ISO3166_N: {record.Address.ISO3166_N}\n" +
          $"  AdministrativeArea: {record.Address.AdministrativeArea}\n" +
          $"  SubAdministrativeArea: {record.Address.SubAdministrativeArea}\n" +
          $"  Locality: {record.Address.Locality}\n" +
          $"  CityAccepted: {record.Address.CityAccepted}\n" +
          $"  Thoroughfare: {record.Address.Thoroughfare}\n" +
          $"  Premise: {record.Address.Premise}\n" +
          $"  SubBuilding: {record.Address.SubBuilding}\n" +
          $"  PostalCode: {record.Address.PostalCode}\n" +
          $"  PostalCodePrimary: {record.Address.PostalCodePrimary}\n" +
          $"  PostalCodeSecondary: {record.Address.PostalCodeSecondary}\n" +
          $"  CountrySubdivisionCode: {record.Address.CountrySubdivisionCode}\n" +
          $"  MAK: {record.Address.MAK}\n" +
          $"  BaseMAK: {record.Address.BaseMAK}\n" +
          $"  DistanceFromPoint: {record.Address.DistanceFromPoint}\n");
      }

      globalExpressEntry.Clear();


      globalExpressEntry.SetThoroughfare("avenida empresa");
      globalExpressEntry.SetPostal("92688");
      globalExpressEntry.SetCountry("united states");

      response = await globalExpressEntry.GetGlobalExpressThoroughfareAsync<string>();
      globalResponseObject = await globalExpressEntry.GetGlobalExpressThoroughfareAsync<GlobalExpressEntryResponse>();

      Console.WriteLine(response);

      Console.WriteLine($"\nVersion: {globalResponseObject.Version}");
      Console.WriteLine($"ResultCode: {globalResponseObject.ResultCode}");
      Console.WriteLine($"ErrorString: {globalResponseObject.ErrorString}\n");
      foreach (var record in globalResponseObject.Results)
      {
        Console.WriteLine($"Address: \n" +
          $"  Address: {record.Address.Address}\n" +
          $"  Address1: {record.Address.Address1}\n" +
          $"  Address2: {record.Address.Address2}\n" +
          $"  DeliveryAddress: {record.Address.DeliveryAddress}\n" +
          $"  DeliveryAddress1: {record.Address.DeliveryAddress1}\n" +
          $"  CountryName: {record.Address.CountryName}\n" +
          $"  ISO3166_2: {record.Address.ISO3166_2}\n" +
          $"  ISO3166_3: {record.Address.ISO3166_3}\n" +
          $"  ISO3166_N: {record.Address.ISO3166_N}\n" +
          $"  AdministrativeArea: {record.Address.AdministrativeArea}\n" +
          $"  SubAdministrativeArea: {record.Address.SubAdministrativeArea}\n" +
          $"  Locality: {record.Address.Locality}\n" +
          $"  CityAccepted: {record.Address.CityAccepted}\n" +
          $"  Thoroughfare: {record.Address.Thoroughfare}\n" +
          $"  Premise: {record.Address.Premise}\n" +
          $"  SubBuilding: {record.Address.SubBuilding}\n" +
          $"  PostalCode: {record.Address.PostalCode}\n" +
          $"  PostalCodePrimary: {record.Address.PostalCodePrimary}\n" +
          $"  PostalCodeSecondary: {record.Address.PostalCodeSecondary}\n" +
          $"  CountrySubdivisionCode: {record.Address.CountrySubdivisionCode}\n" +
          $"  MAK: {record.Address.MAK}\n" +
          $"  BaseMAK: {record.Address.BaseMAK}\n" +
          $"  DistanceFromPoint: {record.Address.DistanceFromPoint}\n");
      }
    }

    public void GlobalExpressEntrySetValueSample()
    {
      GlobalExpressEntry globalExpressEntry = new GlobalExpressEntry(licenseKey);
      globalExpressEntry.SetValue("AddressLine1", "22382 Avenida Empresa");
      globalExpressEntry.SetValue("City", "RSM");
      globalExpressEntry.SetValue("State", "CA");
      globalExpressEntry.SetValue("Postal", "92688");

      string response = globalExpressEntry.GetExpressAddress<string>();
      ExpressEntryResponse responseObject = globalExpressEntry.GetExpressAddress<ExpressEntryResponse>();

      Console.WriteLine(response);

      Console.WriteLine($"\nVersion: {responseObject.Version}");
      Console.WriteLine($"ResultCode: {responseObject.ResultCode}");
      Console.WriteLine($"ErrorString: {responseObject.ErrorString}\n");
      foreach (var record in responseObject.Results)
      {
        Console.WriteLine($"Address: \n" +
          $"  AddressLine1: {record.Address.AddressLine1}\n" +
          $"  City: {record.Address.City}\n" +
          $"  CityAccepted: {record.Address.CityAccepted}\n" +
          $"  State: {record.Address.State}\n" +
          $"  PostalCode: {record.Address.PostalCode}\n" +
          $"  CountrySubdivisionCode: {record.Address.CountrySubdivisionCode}\n" +
          $"  AddressKey: {record.Address.AddressKey}\n" +
          $"  SuiteCount: {record.Address.SuiteCount}\n" +
          $"  Plus4: {record.Address.PlusFour[0]}\n" +
          $"  MAK: {record.Address.MAK}\n");
      }
    }

    public void GlobalExpressEntrySetValueSample2()
    {
      GlobalExpressEntry globalExpressEntry = new GlobalExpressEntry(licenseKey);
      globalExpressEntry.AddressLine1 = "22382 Avenida Empresa";
      globalExpressEntry.City = "RSM";
      globalExpressEntry.State = "CA";
      globalExpressEntry.Postal = "92688";

      string response = globalExpressEntry.GetExpressAddress<string>();
      ExpressEntryResponse responseObject = globalExpressEntry.GetExpressAddress<ExpressEntryResponse>();

      Console.WriteLine(response);

      Console.WriteLine($"\nVersion: {responseObject.Version}");
      Console.WriteLine($"ResultCode: {responseObject.ResultCode}");
      Console.WriteLine($"ErrorString: {responseObject.ErrorString}\n");
      foreach (var record in responseObject.Results)
      {
        Console.WriteLine($"Address: \n" +
          $"  AddressLine1: {record.Address.AddressLine1}\n" +
          $"  City: {record.Address.City}\n" +
          $"  CityAccepted: {record.Address.CityAccepted}\n" +
          $"  State: {record.Address.State}\n" +
          $"  PostalCode: {record.Address.PostalCode}\n" +
          $"  CountrySubdivisionCode: {record.Address.CountrySubdivisionCode}\n" +
          $"  AddressKey: {record.Address.AddressKey}\n" +
          $"  SuiteCount: {record.Address.SuiteCount}\n" +
          $"  Plus4: {record.Address.PlusFour[0]}\n" +
          $"  MAK: {record.Address.MAK}\n");
      }
    }
  }
}
