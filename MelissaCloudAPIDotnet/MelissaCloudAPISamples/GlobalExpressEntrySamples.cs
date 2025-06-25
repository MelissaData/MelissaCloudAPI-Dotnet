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
      globalExpressEntry.SetAddressLine1("Avenida Empresa, Rancho Santa Margarita, CA");
      globalExpressEntry.SetLocality("Rancho Santa Margarita");
      globalExpressEntry.SetAdministrativeArea("CA");
      globalExpressEntry.SetPostal("92688");
      globalExpressEntry.SetCountry("United States");
      globalExpressEntry.SetMaxRecords("2");

      string response = globalExpressEntry.GetGlobalExpressAddress<string>();
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
      globalExpressEntry.SetAddressLine1("Avenida Empresa, Rancho Santa Margarita, CA");
      globalExpressEntry.SetLocality("Rancho Santa Margarita");
      globalExpressEntry.SetAdministrativeArea("CA");
      globalExpressEntry.SetPostal("92688");
      globalExpressEntry.SetCountry("United States");
      globalExpressEntry.SetMaxRecords("2");

      string response = await globalExpressEntry.GetGlobalExpressAddressAsync<string>();
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

      string response = globalExpressEntry.GetGlobalExpressAddress<string>();
      GlobalExpressEntryResponse responseObject = globalExpressEntry.GetGlobalExpressAddress<GlobalExpressEntryResponse>();

      Console.WriteLine(response);

      Console.WriteLine($"\nVersion: {responseObject.Version}");
      Console.WriteLine($"ResultCode: {responseObject.ResultCode}");
      Console.WriteLine($"ErrorString: {responseObject.ErrorString}\n");
      foreach (var record in responseObject.Results)
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

    public void GlobalExpressEntrySetValueSample2()
    {
      GlobalExpressEntry globalExpressEntry = new GlobalExpressEntry(licenseKey);
      globalExpressEntry.AddressLine1 = "22382 Avenida Empresa";
      globalExpressEntry.City = "RSM";
      globalExpressEntry.State = "CA";
      globalExpressEntry.Postal = "92688";

      string response = globalExpressEntry.GetGlobalExpressAddress<string>();
      GlobalExpressEntryResponse responseObject = globalExpressEntry.GetGlobalExpressAddress<GlobalExpressEntryResponse>();

      Console.WriteLine(response);

      Console.WriteLine($"\nVersion: {responseObject.Version}");
      Console.WriteLine($"ResultCode: {responseObject.ResultCode}");
      Console.WriteLine($"ErrorString: {responseObject.ErrorString}\n");
      foreach (var record in responseObject.Results)
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
  }
}
