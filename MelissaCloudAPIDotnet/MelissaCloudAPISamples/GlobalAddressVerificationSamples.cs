using MelissaData.CloudAPI;

namespace MelissaCloudAPIDotnet.MelissaCloudAPISamples
{
  public class GlobalAddressVerificationSamples
  {
    public string licenseKey;

    public GlobalAddressVerificationSamples(string licenseKey) 
    {
      this.licenseKey = licenseKey;
    }

    /// <summary>
    /// This function uses the Global Address Verification Cloud API object to make a GET request
    /// </summary>
    public void GlobalAddressVerificationSample()
    {
      GlobalAddressVerification globalAddress = new GlobalAddressVerification(licenseKey);
      globalAddress.SetAddressLine1("22382 Avenida Empresa");
      globalAddress.SetLocality("Rancho Santa Margarita");
      globalAddress.SetAdministrativeArea("CA");
      globalAddress.SetPostal("92688");
      globalAddress.SetCountry("United States");
      globalAddress.SetOpt("USExtras:ON");

      string response = globalAddress.Get<string>();
      GlobalAddressVerificationResponse responseObject = globalAddress.Get<GlobalAddressVerificationResponse>();

      Console.WriteLine(response);

      Console.WriteLine($"\nVersion: {responseObject.Version}");
      Console.WriteLine($"TransmissionReference: {responseObject.TransmissionReference}");
      Console.WriteLine($"TransmissionResults: {responseObject.TransmissionResults}");
      Console.WriteLine($"TotalRecords: {responseObject.TotalRecords}\n");
      foreach (var record in responseObject.Records)
      {
        Console.WriteLine("RecordID: " + record.RecordID);
        Console.WriteLine("Results: " + record.Results);
        Console.WriteLine("Formatted: " + record.FormattedAddress);
        Console.WriteLine("Organization: " + record.Organization);
        Console.WriteLine("AddressLine1: " + record.AddressLine1);
        Console.WriteLine("AddressLine2: " + record.AddressLine2);
        Console.WriteLine("AddressLine3: " + record.AddressLine3);
        Console.WriteLine("AddressLine4: " + record.AddressLine4);
        Console.WriteLine("AddressLine5: " + record.AddressLine5);
        Console.WriteLine("AddressLine6: " + record.AddressLine6);
        Console.WriteLine("AddressLine7: " + record.AddressLine7);
        Console.WriteLine("AddressLine8: " + record.AddressLine8);
        Console.WriteLine("SubPremises: " + record.SubPremises);
        Console.WriteLine("DoubleDependentLocality: " + record.DoubleDependentLocality);
        Console.WriteLine("DependentLocality: " + record.DependentLocality);
        Console.WriteLine("Locality: " + record.Locality);
        Console.WriteLine("SubAdministrativeArea: " + record.SubAdministrativeArea);
        Console.WriteLine("AdministrativeArea: " + record.AdministrativeArea);
        Console.WriteLine("PostalCode: " + record.PostalCode);
        Console.WriteLine("PostalCodeType: " + record.PostalCodeType);
        Console.WriteLine("AddressType: " + record.AddressType);
        Console.WriteLine("AddressKey: " + record.AddressKey);
        Console.WriteLine("SubNationalArea: " + record.SubNationalArea);
        Console.WriteLine("CountryName: " + record.CountryName);
        Console.WriteLine("CountryISO3166_1_Alpha2: " + record.CountryISO3166_1_Alpha2);
        Console.WriteLine("CountryISO3166_1_Alpha3: " + record.CountryISO3166_1_Alpha3);
        Console.WriteLine("CountryISO3166_1_Numeric: " + record.CountryISO3166_1_Numeric);
        Console.WriteLine("CountrySubdivisionCode: " + record.CountrySubdivisionCode);
        Console.WriteLine("Thoroughfare: " + record.Thoroughfare);
        Console.WriteLine("ThoroughfarePreDirection: " + record.ThoroughfarePreDirection);
        Console.WriteLine("ThoroughfareLeadingType: " + record.ThoroughfareLeadingType);
        Console.WriteLine("ThoroughfareName: " + record.ThoroughfareName);
        Console.WriteLine("ThoroughfareTrailingType: " + record.ThoroughfareTrailingType);
        Console.WriteLine("ThoroughfarePostDirection: " + record.ThoroughfarePostDirection);
        Console.WriteLine("DependentThoroughfare: " + record.DependentThoroughfare);
        Console.WriteLine("DependentThoroughfarePreDirection: " + record.DependentThoroughfarePreDirection);
        Console.WriteLine("DependentThoroughfareLeadingType: " + record.DependentThoroughfareLeadingType);
        Console.WriteLine("DependentThoroughfareName: " + record.DependentThoroughfareName);
        Console.WriteLine("DependentThoroughfareTrailingType: " + record.DependentThoroughfareTrailingType);
        Console.WriteLine("DependentThoroughfarePostDirection: " + record.DependentThoroughfarePostDirection);
        Console.WriteLine("Building: " + record.Building);
        Console.WriteLine("PremisesType: " + record.PremisesType);
        Console.WriteLine("PremisesNumber: " + record.PremisesNumber);
        Console.WriteLine("SubPremisesType: " + record.SubPremisesType);
        Console.WriteLine("SubPremisesNumber: " + record.SubPremisesNumber);
        Console.WriteLine("PostBox: " + record.PostBox);
        Console.WriteLine("Latitude: " + record.Latitude);
        Console.WriteLine("Longitude: " + record.Longitude);
        Console.WriteLine("DeliveryIndicator: " + record.DeliveryIndicator);
        Console.WriteLine("MelissaAddressKey: " + record.MelissaAddressKey);
        Console.WriteLine("MelissaAddressKeyBase: " + record.MelissaAddressKeyBase);
        Console.WriteLine("PostOfficeLocation: " + record.PostOfficeLocation);
        Console.WriteLine("SubPremiseLevel: " + record.SubPremiseLevel);
        Console.WriteLine("SubPremiseLevelType: " + record.SubPremiseLevelType);
        Console.WriteLine("SubPremiseLevelNumber: " + record.SubPremiseLevelNumber);
        Console.WriteLine("SubBuilding: " + record.SubBuilding);
        Console.WriteLine("SubBuildingType: " + record.SubBuildingType);
        Console.WriteLine("SubBuildingNumber: " + record.SubBuildingNumber);
        Console.WriteLine("UTC: " + record.UTC);
        Console.WriteLine("DST: " + record.DST);
        Console.WriteLine("DeliveryPointSuffix: " + record.DeliveryPointSuffix);
        Console.WriteLine("CensusKey: " + record.CensusKey);

        // Extras
        Console.WriteLine("CBSACode: " + record.Extras.CBSACode);
        Console.WriteLine("CBSADivisionCode: " + record.Extras.CBSADivisionCode);
        Console.WriteLine("CBSADivisionLevel: " + record.Extras.CBSADivisionLevel);
        Console.WriteLine("CBSADivisionTitle: " + record.Extras.CBSADivisionTitle);
        Console.WriteLine("CBSALevel: " + record.Extras.CBSALevel);
        Console.WriteLine("CBSATitle: " + record.Extras.CBSATitle);
        Console.WriteLine("CarrierRoute: " + record.Extras.CarrierRoute);
        Console.WriteLine("CensusBlock: " + record.Extras.CensusBlock);
        Console.WriteLine("CensusTract: " + record.Extras.CensusTract);
        Console.WriteLine("CongressionalDistrict: " + record.Extras.CongressionalDistrict);
        Console.WriteLine("CountyFIPS: " + record.Extras.CountyFIPS);
        Console.WriteLine("CountySubdivisionCode: " + record.Extras.CountySubdivisionCode);
        Console.WriteLine("CountySubdivisionName: " + record.Extras.CountySubdivisionName);
        Console.WriteLine("DeliveryPointCheckDigit: " + record.Extras.DeliveryPointCheckDigit);
        Console.WriteLine("DeliveryPointCode: " + record.Extras.DeliveryPointCode);
        Console.WriteLine("PlaceCode: " + record.Extras.PlaceCode);
        Console.WriteLine("PlaceName: " + record.Extras.PlaceName);
        Console.WriteLine("StateDistrictLower: " + record.Extras.StateDistrictLower);
        Console.WriteLine("StateDistrictUpper: " + record.Extras.StateDistrictUpper);
        Console.WriteLine("UnifiedSchoolDistrictCode: " + record.Extras.UnifiedSchoolDistrictCode);
        Console.WriteLine("UnifiedSchoolDistrictName: " + record.Extras.UnifiedSchoolDistrictName);
      }
    }

    /// <summary>
    /// This asynchronous function uses the Global Address Verification Cloud API object to make a GET request
    /// </summary>
    public async Task GlobalAddressVerificationAsyncSample()
    {
      GlobalAddressVerification globalAddress = new GlobalAddressVerification(licenseKey);
      globalAddress.SetAddressLine1("22382 Avenida Empresa");
      globalAddress.SetLocality("Rancho Santa Margarita");
      globalAddress.SetAdministrativeArea("CA");
      globalAddress.SetPostal("92688");
      globalAddress.SetCountry("United States");
      globalAddress.SetOpt("USExtras:ON");

      string response = await globalAddress.GetAsync<string>();
      GlobalAddressVerificationResponse responseObject = await globalAddress.GetAsync<GlobalAddressVerificationResponse>();

      Console.WriteLine(response);

      Console.WriteLine($"\nVersion: {responseObject.Version}");
      Console.WriteLine($"TransmissionReference: {responseObject.TransmissionReference}");
      Console.WriteLine($"TransmissionResults: {responseObject.TransmissionResults}");
      Console.WriteLine($"TotalRecords: {responseObject.TotalRecords}\n");
      foreach (var record in responseObject.Records)
      {
        Console.WriteLine("RecordID: " + record.RecordID);
        Console.WriteLine("Results: " + record.Results);
        Console.WriteLine("Formatted: " + record.FormattedAddress);
        Console.WriteLine("Organization: " + record.Organization);
        Console.WriteLine("AddressLine1: " + record.AddressLine1);
        Console.WriteLine("AddressLine2: " + record.AddressLine2);
        Console.WriteLine("AddressLine3: " + record.AddressLine3);
        Console.WriteLine("AddressLine4: " + record.AddressLine4);
        Console.WriteLine("AddressLine5: " + record.AddressLine5);
        Console.WriteLine("AddressLine6: " + record.AddressLine6);
        Console.WriteLine("AddressLine7: " + record.AddressLine7);
        Console.WriteLine("AddressLine8: " + record.AddressLine8);
        Console.WriteLine("SubPremises: " + record.SubPremises);
        Console.WriteLine("DoubleDependentLocality: " + record.DoubleDependentLocality);
        Console.WriteLine("DependentLocality: " + record.DependentLocality);
        Console.WriteLine("Locality: " + record.Locality);
        Console.WriteLine("SubAdministrativeArea: " + record.SubAdministrativeArea);
        Console.WriteLine("AdministrativeArea: " + record.AdministrativeArea);
        Console.WriteLine("PostalCode: " + record.PostalCode);
        Console.WriteLine("PostalCodeType: " + record.PostalCodeType);
        Console.WriteLine("AddressType: " + record.AddressType);
        Console.WriteLine("AddressKey: " + record.AddressKey);
        Console.WriteLine("SubNationalArea: " + record.SubNationalArea);
        Console.WriteLine("CountryName: " + record.CountryName);
        Console.WriteLine("CountryISO3166_1_Alpha2: " + record.CountryISO3166_1_Alpha2);
        Console.WriteLine("CountryISO3166_1_Alpha3: " + record.CountryISO3166_1_Alpha3);
        Console.WriteLine("CountryISO3166_1_Numeric: " + record.CountryISO3166_1_Numeric);
        Console.WriteLine("CountrySubdivisionCode: " + record.CountrySubdivisionCode);
        Console.WriteLine("Thoroughfare: " + record.Thoroughfare);
        Console.WriteLine("ThoroughfarePreDirection: " + record.ThoroughfarePreDirection);
        Console.WriteLine("ThoroughfareLeadingType: " + record.ThoroughfareLeadingType);
        Console.WriteLine("ThoroughfareName: " + record.ThoroughfareName);
        Console.WriteLine("ThoroughfareTrailingType: " + record.ThoroughfareTrailingType);
        Console.WriteLine("ThoroughfarePostDirection: " + record.ThoroughfarePostDirection);
        Console.WriteLine("DependentThoroughfare: " + record.DependentThoroughfare);
        Console.WriteLine("DependentThoroughfarePreDirection: " + record.DependentThoroughfarePreDirection);
        Console.WriteLine("DependentThoroughfareLeadingType: " + record.DependentThoroughfareLeadingType);
        Console.WriteLine("DependentThoroughfareName: " + record.DependentThoroughfareName);
        Console.WriteLine("DependentThoroughfareTrailingType: " + record.DependentThoroughfareTrailingType);
        Console.WriteLine("DependentThoroughfarePostDirection: " + record.DependentThoroughfarePostDirection);
        Console.WriteLine("Building: " + record.Building);
        Console.WriteLine("PremisesType: " + record.PremisesType);
        Console.WriteLine("PremisesNumber: " + record.PremisesNumber);
        Console.WriteLine("SubPremisesType: " + record.SubPremisesType);
        Console.WriteLine("SubPremisesNumber: " + record.SubPremisesNumber);
        Console.WriteLine("PostBox: " + record.PostBox);
        Console.WriteLine("Latitude: " + record.Latitude);
        Console.WriteLine("Longitude: " + record.Longitude);
        Console.WriteLine("DeliveryIndicator: " + record.DeliveryIndicator);
        Console.WriteLine("MelissaAddressKey: " + record.MelissaAddressKey);
        Console.WriteLine("MelissaAddressKeyBase: " + record.MelissaAddressKeyBase);
        Console.WriteLine("PostOfficeLocation: " + record.PostOfficeLocation);
        Console.WriteLine("SubPremiseLevel: " + record.SubPremiseLevel);
        Console.WriteLine("SubPremiseLevelType: " + record.SubPremiseLevelType);
        Console.WriteLine("SubPremiseLevelNumber: " + record.SubPremiseLevelNumber);
        Console.WriteLine("SubBuilding: " + record.SubBuilding);
        Console.WriteLine("SubBuildingType: " + record.SubBuildingType);
        Console.WriteLine("SubBuildingNumber: " + record.SubBuildingNumber);
        Console.WriteLine("UTC: " + record.UTC);
        Console.WriteLine("DST: " + record.DST);
        Console.WriteLine("DeliveryPointSuffix: " + record.DeliveryPointSuffix);
        Console.WriteLine("CensusKey: " + record.CensusKey);

        // Extras
        Console.WriteLine("CBSACode: " + record.Extras.CBSACode);
        Console.WriteLine("CBSADivisionCode: " + record.Extras.CBSADivisionCode);
        Console.WriteLine("CBSADivisionLevel: " + record.Extras.CBSADivisionLevel);
        Console.WriteLine("CBSADivisionTitle: " + record.Extras.CBSADivisionTitle);
        Console.WriteLine("CBSALevel: " + record.Extras.CBSALevel);
        Console.WriteLine("CBSATitle: " + record.Extras.CBSATitle);
        Console.WriteLine("CarrierRoute: " + record.Extras.CarrierRoute);
        Console.WriteLine("CensusBlock: " + record.Extras.CensusBlock);
        Console.WriteLine("CensusTract: " + record.Extras.CensusTract);
        Console.WriteLine("CongressionalDistrict: " + record.Extras.CongressionalDistrict);
        Console.WriteLine("CountyFIPS: " + record.Extras.CountyFIPS);
        Console.WriteLine("CountySubdivisionCode: " + record.Extras.CountySubdivisionCode);
        Console.WriteLine("CountySubdivisionName: " + record.Extras.CountySubdivisionName);
        Console.WriteLine("DeliveryPointCheckDigit: " + record.Extras.DeliveryPointCheckDigit);
        Console.WriteLine("DeliveryPointCode: " + record.Extras.DeliveryPointCode);
        Console.WriteLine("PlaceCode: " + record.Extras.PlaceCode);
        Console.WriteLine("PlaceName: " + record.Extras.PlaceName);
        Console.WriteLine("StateDistrictLower: " + record.Extras.StateDistrictLower);
        Console.WriteLine("StateDistrictUpper: " + record.Extras.StateDistrictUpper);
        Console.WriteLine("UnifiedSchoolDistrictCode: " + record.Extras.UnifiedSchoolDistrictCode);
        Console.WriteLine("UnifiedSchoolDistrictName: " + record.Extras.UnifiedSchoolDistrictName);
      }
    }


    /// <summary>
    /// This function uses the Global Address Verification Cloud API object to make a POST BATCH request
    /// This function showcases method 1 of setting and making POST requests: construct the POST body structure using the Cloud API's respective PostRequest class
    /// </summary>
    public void GlobalAddressVerificationBatch1Sample()
    {
      GlobalAddressVerification globalAddress = new GlobalAddressVerification();
      globalAddress.SetPostBody(new GlobalAddressVerificationPostRequest
      {
        CustomerID = licenseKey,
        Options = "USExtras:ON",
        Records = new List<GlobalAddressVerificationRecordRequest>
        {
          new GlobalAddressVerificationRecordRequest
          {
            RecordID = "1",
           AddressLine1 = "22382 Avenida Empresa",
           Locality = "Rancho Santa Margarita",
           AdministrativeArea = "CA",
           PostalCode = "92688",
           Country = "US"
          },
          new GlobalAddressVerificationRecordRequest
          {
            RecordID = "2",
            AddressLine1 = "30 Dunn Dr",
            Locality = "Bay Bulls",
            AdministrativeArea = "NL",
            PostalCode = "A0A1C0",
            Country = "CA"
          }
        }
      });

      string response = globalAddress.Post<string>();
      GlobalAddressVerificationResponse responseObject = globalAddress.Post<GlobalAddressVerificationResponse>();

      Console.WriteLine(response);

      Console.WriteLine($"\nVersion: {responseObject.Version}");
      Console.WriteLine($"TransmissionReference: {responseObject.TransmissionReference}");
      Console.WriteLine($"TransmissionResults: {responseObject.TransmissionResults}");
      Console.WriteLine($"TotalRecords: {responseObject.TotalRecords}\n");
      foreach (var record in responseObject.Records)
      {
        Console.WriteLine("RecordID: " + record.RecordID);
        Console.WriteLine("Results: " + record.Results);
        Console.WriteLine("Formatted: " + record.FormattedAddress);
        Console.WriteLine("Organization: " + record.Organization);
        Console.WriteLine("AddressLine1: " + record.AddressLine1);
        Console.WriteLine("AddressLine2: " + record.AddressLine2);
        Console.WriteLine("AddressLine3: " + record.AddressLine3);
        Console.WriteLine("AddressLine4: " + record.AddressLine4);
        Console.WriteLine("AddressLine5: " + record.AddressLine5);
        Console.WriteLine("AddressLine6: " + record.AddressLine6);
        Console.WriteLine("AddressLine7: " + record.AddressLine7);
        Console.WriteLine("AddressLine8: " + record.AddressLine8);
        Console.WriteLine("SubPremises: " + record.SubPremises);
        Console.WriteLine("DoubleDependentLocality: " + record.DoubleDependentLocality);
        Console.WriteLine("DependentLocality: " + record.DependentLocality);
        Console.WriteLine("Locality: " + record.Locality);
        Console.WriteLine("SubAdministrativeArea: " + record.SubAdministrativeArea);
        Console.WriteLine("AdministrativeArea: " + record.AdministrativeArea);
        Console.WriteLine("PostalCode: " + record.PostalCode);
        Console.WriteLine("PostalCodeType: " + record.PostalCodeType);
        Console.WriteLine("AddressType: " + record.AddressType);
        Console.WriteLine("AddressKey: " + record.AddressKey);
        Console.WriteLine("SubNationalArea: " + record.SubNationalArea);
        Console.WriteLine("CountryName: " + record.CountryName);
        Console.WriteLine("CountryISO3166_1_Alpha2: " + record.CountryISO3166_1_Alpha2);
        Console.WriteLine("CountryISO3166_1_Alpha3: " + record.CountryISO3166_1_Alpha3);
        Console.WriteLine("CountryISO3166_1_Numeric: " + record.CountryISO3166_1_Numeric);
        Console.WriteLine("CountrySubdivisionCode: " + record.CountrySubdivisionCode);
        Console.WriteLine("Thoroughfare: " + record.Thoroughfare);
        Console.WriteLine("ThoroughfarePreDirection: " + record.ThoroughfarePreDirection);
        Console.WriteLine("ThoroughfareLeadingType: " + record.ThoroughfareLeadingType);
        Console.WriteLine("ThoroughfareName: " + record.ThoroughfareName);
        Console.WriteLine("ThoroughfareTrailingType: " + record.ThoroughfareTrailingType);
        Console.WriteLine("ThoroughfarePostDirection: " + record.ThoroughfarePostDirection);
        Console.WriteLine("DependentThoroughfare: " + record.DependentThoroughfare);
        Console.WriteLine("DependentThoroughfarePreDirection: " + record.DependentThoroughfarePreDirection);
        Console.WriteLine("DependentThoroughfareLeadingType: " + record.DependentThoroughfareLeadingType);
        Console.WriteLine("DependentThoroughfareName: " + record.DependentThoroughfareName);
        Console.WriteLine("DependentThoroughfareTrailingType: " + record.DependentThoroughfareTrailingType);
        Console.WriteLine("DependentThoroughfarePostDirection: " + record.DependentThoroughfarePostDirection);
        Console.WriteLine("Building: " + record.Building);
        Console.WriteLine("PremisesType: " + record.PremisesType);
        Console.WriteLine("PremisesNumber: " + record.PremisesNumber);
        Console.WriteLine("SubPremisesType: " + record.SubPremisesType);
        Console.WriteLine("SubPremisesNumber: " + record.SubPremisesNumber);
        Console.WriteLine("PostBox: " + record.PostBox);
        Console.WriteLine("Latitude: " + record.Latitude);
        Console.WriteLine("Longitude: " + record.Longitude);
        Console.WriteLine("DeliveryIndicator: " + record.DeliveryIndicator);
        Console.WriteLine("MelissaAddressKey: " + record.MelissaAddressKey);
        Console.WriteLine("MelissaAddressKeyBase: " + record.MelissaAddressKeyBase);
        Console.WriteLine("PostOfficeLocation: " + record.PostOfficeLocation);
        Console.WriteLine("SubPremiseLevel: " + record.SubPremiseLevel);
        Console.WriteLine("SubPremiseLevelType: " + record.SubPremiseLevelType);
        Console.WriteLine("SubPremiseLevelNumber: " + record.SubPremiseLevelNumber);
        Console.WriteLine("SubBuilding: " + record.SubBuilding);
        Console.WriteLine("SubBuildingType: " + record.SubBuildingType);
        Console.WriteLine("SubBuildingNumber: " + record.SubBuildingNumber);
        Console.WriteLine("UTC: " + record.UTC);
        Console.WriteLine("DST: " + record.DST);
        Console.WriteLine("DeliveryPointSuffix: " + record.DeliveryPointSuffix);
        Console.WriteLine("CensusKey: " + record.CensusKey);

        // Extras
        Console.WriteLine("CBSACode: " + record.Extras.CBSACode);
        Console.WriteLine("CBSADivisionCode: " + record.Extras.CBSADivisionCode);
        Console.WriteLine("CBSADivisionLevel: " + record.Extras.CBSADivisionLevel);
        Console.WriteLine("CBSADivisionTitle: " + record.Extras.CBSADivisionTitle);
        Console.WriteLine("CBSALevel: " + record.Extras.CBSALevel);
        Console.WriteLine("CBSATitle: " + record.Extras.CBSATitle);
        Console.WriteLine("CarrierRoute: " + record.Extras.CarrierRoute);
        Console.WriteLine("CensusBlock: " + record.Extras.CensusBlock);
        Console.WriteLine("CensusTract: " + record.Extras.CensusTract);
        Console.WriteLine("CongressionalDistrict: " + record.Extras.CongressionalDistrict);
        Console.WriteLine("CountyFIPS: " + record.Extras.CountyFIPS);
        Console.WriteLine("CountySubdivisionCode: " + record.Extras.CountySubdivisionCode);
        Console.WriteLine("CountySubdivisionName: " + record.Extras.CountySubdivisionName);
        Console.WriteLine("DeliveryPointCheckDigit: " + record.Extras.DeliveryPointCheckDigit);
        Console.WriteLine("DeliveryPointCode: " + record.Extras.DeliveryPointCode);
        Console.WriteLine("PlaceCode: " + record.Extras.PlaceCode);
        Console.WriteLine("PlaceName: " + record.Extras.PlaceName);
        Console.WriteLine("StateDistrictLower: " + record.Extras.StateDistrictLower);
        Console.WriteLine("StateDistrictUpper: " + record.Extras.StateDistrictUpper);
        Console.WriteLine("UnifiedSchoolDistrictCode: " + record.Extras.UnifiedSchoolDistrictCode);
        Console.WriteLine("UnifiedSchoolDistrictName: " + record.Extras.UnifiedSchoolDistrictName + "\n\n");
      }
    }

    /// <summary>
    /// This function uses the Global Address Verification Cloud API object to make a POST BATCH request
    /// This function showcases method 2 of setting and making POST requests: construct the POST body record by using the Cloud API's respective RecordRequest class
    /// </summary>
    public void GlobalAddressVerificationBatch2Sample()
    {
      GlobalAddressVerification globalAddress = new GlobalAddressVerification(licenseKey);
      globalAddress.SetOpt("USExtras:ON");
      globalAddress.AddRecord(new GlobalAddressVerificationRecordRequest
      {
        RecordID = "1",
        AddressLine1 = "22382 Avenida Empresa",
        Locality = "Rancho Santa Margarita",
        AdministrativeArea = "CA",
        PostalCode = "92688",
        Country = "US"
      });
      globalAddress.AddRecord(new GlobalAddressVerificationRecordRequest
      {
        RecordID = "2",
        AddressLine1 = "30 Dunn Dr",
        Locality = "Bay Bulls",
        AdministrativeArea = "NL",
        PostalCode = "A0A1C0",
        Country = "CA"
      });

      string response = globalAddress.Post<string>();
      GlobalAddressVerificationResponse responseObject = globalAddress.Post<GlobalAddressVerificationResponse>();

      Console.WriteLine(response);

      Console.WriteLine($"\nVersion: {responseObject.Version}");
      Console.WriteLine($"TransmissionReference: {responseObject.TransmissionReference}");
      Console.WriteLine($"TransmissionResults: {responseObject.TransmissionResults}");
      Console.WriteLine($"TotalRecords: {responseObject.TotalRecords}\n");
      foreach (var record in responseObject.Records)
      {
        Console.WriteLine("RecordID: " + record.RecordID);
        Console.WriteLine("Results: " + record.Results);
        Console.WriteLine("Formatted: " + record.FormattedAddress);
        Console.WriteLine("Organization: " + record.Organization);
        Console.WriteLine("AddressLine1: " + record.AddressLine1);
        Console.WriteLine("AddressLine2: " + record.AddressLine2);
        Console.WriteLine("AddressLine3: " + record.AddressLine3);
        Console.WriteLine("AddressLine4: " + record.AddressLine4);
        Console.WriteLine("AddressLine5: " + record.AddressLine5);
        Console.WriteLine("AddressLine6: " + record.AddressLine6);
        Console.WriteLine("AddressLine7: " + record.AddressLine7);
        Console.WriteLine("AddressLine8: " + record.AddressLine8);
        Console.WriteLine("SubPremises: " + record.SubPremises);
        Console.WriteLine("DoubleDependentLocality: " + record.DoubleDependentLocality);
        Console.WriteLine("DependentLocality: " + record.DependentLocality);
        Console.WriteLine("Locality: " + record.Locality);
        Console.WriteLine("SubAdministrativeArea: " + record.SubAdministrativeArea);
        Console.WriteLine("AdministrativeArea: " + record.AdministrativeArea);
        Console.WriteLine("PostalCode: " + record.PostalCode);
        Console.WriteLine("PostalCodeType: " + record.PostalCodeType);
        Console.WriteLine("AddressType: " + record.AddressType);
        Console.WriteLine("AddressKey: " + record.AddressKey);
        Console.WriteLine("SubNationalArea: " + record.SubNationalArea);
        Console.WriteLine("CountryName: " + record.CountryName);
        Console.WriteLine("CountryISO3166_1_Alpha2: " + record.CountryISO3166_1_Alpha2);
        Console.WriteLine("CountryISO3166_1_Alpha3: " + record.CountryISO3166_1_Alpha3);
        Console.WriteLine("CountryISO3166_1_Numeric: " + record.CountryISO3166_1_Numeric);
        Console.WriteLine("CountrySubdivisionCode: " + record.CountrySubdivisionCode);
        Console.WriteLine("Thoroughfare: " + record.Thoroughfare);
        Console.WriteLine("ThoroughfarePreDirection: " + record.ThoroughfarePreDirection);
        Console.WriteLine("ThoroughfareLeadingType: " + record.ThoroughfareLeadingType);
        Console.WriteLine("ThoroughfareName: " + record.ThoroughfareName);
        Console.WriteLine("ThoroughfareTrailingType: " + record.ThoroughfareTrailingType);
        Console.WriteLine("ThoroughfarePostDirection: " + record.ThoroughfarePostDirection);
        Console.WriteLine("DependentThoroughfare: " + record.DependentThoroughfare);
        Console.WriteLine("DependentThoroughfarePreDirection: " + record.DependentThoroughfarePreDirection);
        Console.WriteLine("DependentThoroughfareLeadingType: " + record.DependentThoroughfareLeadingType);
        Console.WriteLine("DependentThoroughfareName: " + record.DependentThoroughfareName);
        Console.WriteLine("DependentThoroughfareTrailingType: " + record.DependentThoroughfareTrailingType);
        Console.WriteLine("DependentThoroughfarePostDirection: " + record.DependentThoroughfarePostDirection);
        Console.WriteLine("Building: " + record.Building);
        Console.WriteLine("PremisesType: " + record.PremisesType);
        Console.WriteLine("PremisesNumber: " + record.PremisesNumber);
        Console.WriteLine("SubPremisesType: " + record.SubPremisesType);
        Console.WriteLine("SubPremisesNumber: " + record.SubPremisesNumber);
        Console.WriteLine("PostBox: " + record.PostBox);
        Console.WriteLine("Latitude: " + record.Latitude);
        Console.WriteLine("Longitude: " + record.Longitude);
        Console.WriteLine("DeliveryIndicator: " + record.DeliveryIndicator);
        Console.WriteLine("MelissaAddressKey: " + record.MelissaAddressKey);
        Console.WriteLine("MelissaAddressKeyBase: " + record.MelissaAddressKeyBase);
        Console.WriteLine("PostOfficeLocation: " + record.PostOfficeLocation);
        Console.WriteLine("SubPremiseLevel: " + record.SubPremiseLevel);
        Console.WriteLine("SubPremiseLevelType: " + record.SubPremiseLevelType);
        Console.WriteLine("SubPremiseLevelNumber: " + record.SubPremiseLevelNumber);
        Console.WriteLine("SubBuilding: " + record.SubBuilding);
        Console.WriteLine("SubBuildingType: " + record.SubBuildingType);
        Console.WriteLine("SubBuildingNumber: " + record.SubBuildingNumber);
        Console.WriteLine("UTC: " + record.UTC);
        Console.WriteLine("DST: " + record.DST);
        Console.WriteLine("DeliveryPointSuffix: " + record.DeliveryPointSuffix);
        Console.WriteLine("CensusKey: " + record.CensusKey);

        // Extras
        Console.WriteLine("CBSACode: " + record.Extras.CBSACode);
        Console.WriteLine("CBSADivisionCode: " + record.Extras.CBSADivisionCode);
        Console.WriteLine("CBSADivisionLevel: " + record.Extras.CBSADivisionLevel);
        Console.WriteLine("CBSADivisionTitle: " + record.Extras.CBSADivisionTitle);
        Console.WriteLine("CBSALevel: " + record.Extras.CBSALevel);
        Console.WriteLine("CBSATitle: " + record.Extras.CBSATitle);
        Console.WriteLine("CarrierRoute: " + record.Extras.CarrierRoute);
        Console.WriteLine("CensusBlock: " + record.Extras.CensusBlock);
        Console.WriteLine("CensusTract: " + record.Extras.CensusTract);
        Console.WriteLine("CongressionalDistrict: " + record.Extras.CongressionalDistrict);
        Console.WriteLine("CountyFIPS: " + record.Extras.CountyFIPS);
        Console.WriteLine("CountySubdivisionCode: " + record.Extras.CountySubdivisionCode);
        Console.WriteLine("CountySubdivisionName: " + record.Extras.CountySubdivisionName);
        Console.WriteLine("DeliveryPointCheckDigit: " + record.Extras.DeliveryPointCheckDigit);
        Console.WriteLine("DeliveryPointCode: " + record.Extras.DeliveryPointCode);
        Console.WriteLine("PlaceCode: " + record.Extras.PlaceCode);
        Console.WriteLine("PlaceName: " + record.Extras.PlaceName);
        Console.WriteLine("StateDistrictLower: " + record.Extras.StateDistrictLower);
        Console.WriteLine("StateDistrictUpper: " + record.Extras.StateDistrictUpper);
        Console.WriteLine("UnifiedSchoolDistrictCode: " + record.Extras.UnifiedSchoolDistrictCode);
        Console.WriteLine("UnifiedSchoolDistrictName: " + record.Extras.UnifiedSchoolDistrictName + "\n\n");
      }
    }


    /// <summary>
    /// This asynchronous function uses the Global Address Verification Cloud API object to make a POST request
    /// </summary>
    public async Task GlobalAddressVerificationBatchAsyncSample()
    {
      GlobalAddressVerification globalAddress = new GlobalAddressVerification();
      globalAddress.SetPostBody(new GlobalAddressVerificationPostRequest
      {
        CustomerID = licenseKey,
        Options = "USExtras:ON",
        Records = new List<GlobalAddressVerificationRecordRequest>
        {
          new GlobalAddressVerificationRecordRequest
          {
            RecordID = "1",
            AddressLine1 = "22382 Avenida Empresa",
            Locality = "Rancho Santa Margarita",
            AdministrativeArea = "CA",
            PostalCode = "92688",
            Country = "US"
          },
          new GlobalAddressVerificationRecordRequest
          {
            RecordID = "2",
            AddressLine1 = "30 Dunn Dr",
            Locality = "Bay Bulls",
            AdministrativeArea = "NL",
            PostalCode = "A0A1C0",
            Country = "CA"
          }
        }
      });

      string response = await globalAddress.PostAsync<string>();
      GlobalAddressVerificationResponse responseObject = await globalAddress.PostAsync<GlobalAddressVerificationResponse>();

      Console.WriteLine(response);

      Console.WriteLine($"\nVersion: {responseObject.Version}");
      Console.WriteLine($"TransmissionReference: {responseObject.TransmissionReference}");
      Console.WriteLine($"TransmissionResults: {responseObject.TransmissionResults}");
      Console.WriteLine($"TotalRecords: {responseObject.TotalRecords}\n");
      foreach (var record in responseObject.Records)
      {
        Console.WriteLine("RecordID: " + record.RecordID);
        Console.WriteLine("Results: " + record.Results);
        Console.WriteLine("Formatted: " + record.FormattedAddress);
        Console.WriteLine("Organization: " + record.Organization);
        Console.WriteLine("AddressLine1: " + record.AddressLine1);
        Console.WriteLine("AddressLine2: " + record.AddressLine2);
        Console.WriteLine("AddressLine3: " + record.AddressLine3);
        Console.WriteLine("AddressLine4: " + record.AddressLine4);
        Console.WriteLine("AddressLine5: " + record.AddressLine5);
        Console.WriteLine("AddressLine6: " + record.AddressLine6);
        Console.WriteLine("AddressLine7: " + record.AddressLine7);
        Console.WriteLine("AddressLine8: " + record.AddressLine8);
        Console.WriteLine("SubPremises: " + record.SubPremises);
        Console.WriteLine("DoubleDependentLocality: " + record.DoubleDependentLocality);
        Console.WriteLine("DependentLocality: " + record.DependentLocality);
        Console.WriteLine("Locality: " + record.Locality);
        Console.WriteLine("SubAdministrativeArea: " + record.SubAdministrativeArea);
        Console.WriteLine("AdministrativeArea: " + record.AdministrativeArea);
        Console.WriteLine("PostalCode: " + record.PostalCode);
        Console.WriteLine("PostalCodeType: " + record.PostalCodeType);
        Console.WriteLine("AddressType: " + record.AddressType);
        Console.WriteLine("AddressKey: " + record.AddressKey);
        Console.WriteLine("SubNationalArea: " + record.SubNationalArea);
        Console.WriteLine("CountryName: " + record.CountryName);
        Console.WriteLine("CountryISO3166_1_Alpha2: " + record.CountryISO3166_1_Alpha2);
        Console.WriteLine("CountryISO3166_1_Alpha3: " + record.CountryISO3166_1_Alpha3);
        Console.WriteLine("CountryISO3166_1_Numeric: " + record.CountryISO3166_1_Numeric);
        Console.WriteLine("CountrySubdivisionCode: " + record.CountrySubdivisionCode);
        Console.WriteLine("Thoroughfare: " + record.Thoroughfare);
        Console.WriteLine("ThoroughfarePreDirection: " + record.ThoroughfarePreDirection);
        Console.WriteLine("ThoroughfareLeadingType: " + record.ThoroughfareLeadingType);
        Console.WriteLine("ThoroughfareName: " + record.ThoroughfareName);
        Console.WriteLine("ThoroughfareTrailingType: " + record.ThoroughfareTrailingType);
        Console.WriteLine("ThoroughfarePostDirection: " + record.ThoroughfarePostDirection);
        Console.WriteLine("DependentThoroughfare: " + record.DependentThoroughfare);
        Console.WriteLine("DependentThoroughfarePreDirection: " + record.DependentThoroughfarePreDirection);
        Console.WriteLine("DependentThoroughfareLeadingType: " + record.DependentThoroughfareLeadingType);
        Console.WriteLine("DependentThoroughfareName: " + record.DependentThoroughfareName);
        Console.WriteLine("DependentThoroughfareTrailingType: " + record.DependentThoroughfareTrailingType);
        Console.WriteLine("DependentThoroughfarePostDirection: " + record.DependentThoroughfarePostDirection);
        Console.WriteLine("Building: " + record.Building);
        Console.WriteLine("PremisesType: " + record.PremisesType);
        Console.WriteLine("PremisesNumber: " + record.PremisesNumber);
        Console.WriteLine("SubPremisesType: " + record.SubPremisesType);
        Console.WriteLine("SubPremisesNumber: " + record.SubPremisesNumber);
        Console.WriteLine("PostBox: " + record.PostBox);
        Console.WriteLine("Latitude: " + record.Latitude);
        Console.WriteLine("Longitude: " + record.Longitude);
        Console.WriteLine("DeliveryIndicator: " + record.DeliveryIndicator);
        Console.WriteLine("MelissaAddressKey: " + record.MelissaAddressKey);
        Console.WriteLine("MelissaAddressKeyBase: " + record.MelissaAddressKeyBase);
        Console.WriteLine("PostOfficeLocation: " + record.PostOfficeLocation);
        Console.WriteLine("SubPremiseLevel: " + record.SubPremiseLevel);
        Console.WriteLine("SubPremiseLevelType: " + record.SubPremiseLevelType);
        Console.WriteLine("SubPremiseLevelNumber: " + record.SubPremiseLevelNumber);
        Console.WriteLine("SubBuilding: " + record.SubBuilding);
        Console.WriteLine("SubBuildingType: " + record.SubBuildingType);
        Console.WriteLine("SubBuildingNumber: " + record.SubBuildingNumber);
        Console.WriteLine("UTC: " + record.UTC);
        Console.WriteLine("DST: " + record.DST);
        Console.WriteLine("DeliveryPointSuffix: " + record.DeliveryPointSuffix);
        Console.WriteLine("CensusKey: " + record.CensusKey);

        // Extras
        Console.WriteLine("CBSACode: " + record.Extras.CBSACode);
        Console.WriteLine("CBSADivisionCode: " + record.Extras.CBSADivisionCode);
        Console.WriteLine("CBSADivisionLevel: " + record.Extras.CBSADivisionLevel);
        Console.WriteLine("CBSADivisionTitle: " + record.Extras.CBSADivisionTitle);
        Console.WriteLine("CBSALevel: " + record.Extras.CBSALevel);
        Console.WriteLine("CBSATitle: " + record.Extras.CBSATitle);
        Console.WriteLine("CarrierRoute: " + record.Extras.CarrierRoute);
        Console.WriteLine("CensusBlock: " + record.Extras.CensusBlock);
        Console.WriteLine("CensusTract: " + record.Extras.CensusTract);
        Console.WriteLine("CongressionalDistrict: " + record.Extras.CongressionalDistrict);
        Console.WriteLine("CountyFIPS: " + record.Extras.CountyFIPS);
        Console.WriteLine("CountySubdivisionCode: " + record.Extras.CountySubdivisionCode);
        Console.WriteLine("CountySubdivisionName: " + record.Extras.CountySubdivisionName);
        Console.WriteLine("DeliveryPointCheckDigit: " + record.Extras.DeliveryPointCheckDigit);
        Console.WriteLine("DeliveryPointCode: " + record.Extras.DeliveryPointCode);
        Console.WriteLine("PlaceCode: " + record.Extras.PlaceCode);
        Console.WriteLine("PlaceName: " + record.Extras.PlaceName);
        Console.WriteLine("StateDistrictLower: " + record.Extras.StateDistrictLower);
        Console.WriteLine("StateDistrictUpper: " + record.Extras.StateDistrictUpper);
        Console.WriteLine("UnifiedSchoolDistrictCode: " + record.Extras.UnifiedSchoolDistrictCode);
        Console.WriteLine("UnifiedSchoolDistrictName: " + record.Extras.UnifiedSchoolDistrictName + "\n\n");
      }
    }

    /// <summary>
    /// This function uses the Global Address Verification Cloud API object to make a GET request
    /// </summary>
    public void GlobalAddressVerificationSetValueSample()
    {
      GlobalAddressVerification globalAddress = new GlobalAddressVerification(licenseKey);
      globalAddress.SetValue("AddressLine1", "22382 Avenida Empresa");
      globalAddress.SetValue("Locality", "Rancho Santa Margarita");
      globalAddress.SetValue("AdministrativeArea", "CA");
      globalAddress.SetValue("Postal", "92688");
      globalAddress.SetValue("Country", "United States");
      globalAddress.SetValue("Opt", "USExtras:ON");

      string response = globalAddress.Get<string>();
      GlobalAddressVerificationResponse responseObject = globalAddress.Get<GlobalAddressVerificationResponse>();

      Console.WriteLine(response);

      Console.WriteLine($"\nVersion: {responseObject.Version}");
      Console.WriteLine($"TransmissionReference: {responseObject.TransmissionReference}");
      Console.WriteLine($"TransmissionResults: {responseObject.TransmissionResults}");
      Console.WriteLine($"TotalRecords: {responseObject.TotalRecords}\n");
      foreach (var record in responseObject.Records)
      {
        Console.WriteLine("RecordID: " + record.RecordID);
        Console.WriteLine("Results: " + record.Results);
        Console.WriteLine("Formatted: " + record.FormattedAddress);
        Console.WriteLine("Organization: " + record.Organization);
        Console.WriteLine("AddressLine1: " + record.AddressLine1);
        Console.WriteLine("AddressLine2: " + record.AddressLine2);
        Console.WriteLine("AddressLine3: " + record.AddressLine3);
        Console.WriteLine("AddressLine4: " + record.AddressLine4);
        Console.WriteLine("AddressLine5: " + record.AddressLine5);
        Console.WriteLine("AddressLine6: " + record.AddressLine6);
        Console.WriteLine("AddressLine7: " + record.AddressLine7);
        Console.WriteLine("AddressLine8: " + record.AddressLine8);
        Console.WriteLine("SubPremises: " + record.SubPremises);
        Console.WriteLine("DoubleDependentLocality: " + record.DoubleDependentLocality);
        Console.WriteLine("DependentLocality: " + record.DependentLocality);
        Console.WriteLine("Locality: " + record.Locality);
        Console.WriteLine("SubAdministrativeArea: " + record.SubAdministrativeArea);
        Console.WriteLine("AdministrativeArea: " + record.AdministrativeArea);
        Console.WriteLine("PostalCode: " + record.PostalCode);
        Console.WriteLine("PostalCodeType: " + record.PostalCodeType);
        Console.WriteLine("AddressType: " + record.AddressType);
        Console.WriteLine("AddressKey: " + record.AddressKey);
        Console.WriteLine("SubNationalArea: " + record.SubNationalArea);
        Console.WriteLine("CountryName: " + record.CountryName);
        Console.WriteLine("CountryISO3166_1_Alpha2: " + record.CountryISO3166_1_Alpha2);
        Console.WriteLine("CountryISO3166_1_Alpha3: " + record.CountryISO3166_1_Alpha3);
        Console.WriteLine("CountryISO3166_1_Numeric: " + record.CountryISO3166_1_Numeric);
        Console.WriteLine("CountrySubdivisionCode: " + record.CountrySubdivisionCode);
        Console.WriteLine("Thoroughfare: " + record.Thoroughfare);
        Console.WriteLine("ThoroughfarePreDirection: " + record.ThoroughfarePreDirection);
        Console.WriteLine("ThoroughfareLeadingType: " + record.ThoroughfareLeadingType);
        Console.WriteLine("ThoroughfareName: " + record.ThoroughfareName);
        Console.WriteLine("ThoroughfareTrailingType: " + record.ThoroughfareTrailingType);
        Console.WriteLine("ThoroughfarePostDirection: " + record.ThoroughfarePostDirection);
        Console.WriteLine("DependentThoroughfare: " + record.DependentThoroughfare);
        Console.WriteLine("DependentThoroughfarePreDirection: " + record.DependentThoroughfarePreDirection);
        Console.WriteLine("DependentThoroughfareLeadingType: " + record.DependentThoroughfareLeadingType);
        Console.WriteLine("DependentThoroughfareName: " + record.DependentThoroughfareName);
        Console.WriteLine("DependentThoroughfareTrailingType: " + record.DependentThoroughfareTrailingType);
        Console.WriteLine("DependentThoroughfarePostDirection: " + record.DependentThoroughfarePostDirection);
        Console.WriteLine("Building: " + record.Building);
        Console.WriteLine("PremisesType: " + record.PremisesType);
        Console.WriteLine("PremisesNumber: " + record.PremisesNumber);
        Console.WriteLine("SubPremisesType: " + record.SubPremisesType);
        Console.WriteLine("SubPremisesNumber: " + record.SubPremisesNumber);
        Console.WriteLine("PostBox: " + record.PostBox);
        Console.WriteLine("Latitude: " + record.Latitude);
        Console.WriteLine("Longitude: " + record.Longitude);
        Console.WriteLine("DeliveryIndicator: " + record.DeliveryIndicator);
        Console.WriteLine("MelissaAddressKey: " + record.MelissaAddressKey);
        Console.WriteLine("MelissaAddressKeyBase: " + record.MelissaAddressKeyBase);
        Console.WriteLine("PostOfficeLocation: " + record.PostOfficeLocation);
        Console.WriteLine("SubPremiseLevel: " + record.SubPremiseLevel);
        Console.WriteLine("SubPremiseLevelType: " + record.SubPremiseLevelType);
        Console.WriteLine("SubPremiseLevelNumber: " + record.SubPremiseLevelNumber);
        Console.WriteLine("SubBuilding: " + record.SubBuilding);
        Console.WriteLine("SubBuildingType: " + record.SubBuildingType);
        Console.WriteLine("SubBuildingNumber: " + record.SubBuildingNumber);
        Console.WriteLine("UTC: " + record.UTC);
        Console.WriteLine("DST: " + record.DST);
        Console.WriteLine("DeliveryPointSuffix: " + record.DeliveryPointSuffix);
        Console.WriteLine("CensusKey: " + record.CensusKey);

        // Extras
        Console.WriteLine("CBSACode: " + record.Extras.CBSACode);
        Console.WriteLine("CBSADivisionCode: " + record.Extras.CBSADivisionCode);
        Console.WriteLine("CBSADivisionLevel: " + record.Extras.CBSADivisionLevel);
        Console.WriteLine("CBSADivisionTitle: " + record.Extras.CBSADivisionTitle);
        Console.WriteLine("CBSALevel: " + record.Extras.CBSALevel);
        Console.WriteLine("CBSATitle: " + record.Extras.CBSATitle);
        Console.WriteLine("CarrierRoute: " + record.Extras.CarrierRoute);
        Console.WriteLine("CensusBlock: " + record.Extras.CensusBlock);
        Console.WriteLine("CensusTract: " + record.Extras.CensusTract);
        Console.WriteLine("CongressionalDistrict: " + record.Extras.CongressionalDistrict);
        Console.WriteLine("CountyFIPS: " + record.Extras.CountyFIPS);
        Console.WriteLine("CountySubdivisionCode: " + record.Extras.CountySubdivisionCode);
        Console.WriteLine("CountySubdivisionName: " + record.Extras.CountySubdivisionName);
        Console.WriteLine("DeliveryPointCheckDigit: " + record.Extras.DeliveryPointCheckDigit);
        Console.WriteLine("DeliveryPointCode: " + record.Extras.DeliveryPointCode);
        Console.WriteLine("PlaceCode: " + record.Extras.PlaceCode);
        Console.WriteLine("PlaceName: " + record.Extras.PlaceName);
        Console.WriteLine("StateDistrictLower: " + record.Extras.StateDistrictLower);
        Console.WriteLine("StateDistrictUpper: " + record.Extras.StateDistrictUpper);
        Console.WriteLine("UnifiedSchoolDistrictCode: " + record.Extras.UnifiedSchoolDistrictCode);
        Console.WriteLine("UnifiedSchoolDistrictName: " + record.Extras.UnifiedSchoolDistrictName);
      }
    }

    /// <summary>
    /// This function uses the Global Address Verification Cloud API object to make a GET request
    /// </summary>
    public void GlobalAddressVerificationSetValueSample2()
    {
      GlobalAddressVerification globalAddress = new GlobalAddressVerification(licenseKey);
      globalAddress.AddressLine1 = "22382 Avenida Empresa";
      globalAddress.Locality = "Rancho Santa Margarita";
      globalAddress.AdministrativeArea = "CA";
      globalAddress.Postal = "92688";
      globalAddress.Country = "United States";
      globalAddress.Opt = "USExtras:ON";

      string response = globalAddress.Get<string>();
      GlobalAddressVerificationResponse responseObject = globalAddress.Get<GlobalAddressVerificationResponse>();

      Console.WriteLine(response);

      Console.WriteLine($"\nVersion: {responseObject.Version}");
      Console.WriteLine($"TransmissionReference: {responseObject.TransmissionReference}");
      Console.WriteLine($"TransmissionResults: {responseObject.TransmissionResults}");
      Console.WriteLine($"TotalRecords: {responseObject.TotalRecords}\n");
      foreach (var record in responseObject.Records)
      {
        Console.WriteLine("RecordID: " + record.RecordID);
        Console.WriteLine("Results: " + record.Results);
        Console.WriteLine("Formatted: " + record.FormattedAddress);
        Console.WriteLine("Organization: " + record.Organization);
        Console.WriteLine("AddressLine1: " + record.AddressLine1);
        Console.WriteLine("AddressLine2: " + record.AddressLine2);
        Console.WriteLine("AddressLine3: " + record.AddressLine3);
        Console.WriteLine("AddressLine4: " + record.AddressLine4);
        Console.WriteLine("AddressLine5: " + record.AddressLine5);
        Console.WriteLine("AddressLine6: " + record.AddressLine6);
        Console.WriteLine("AddressLine7: " + record.AddressLine7);
        Console.WriteLine("AddressLine8: " + record.AddressLine8);
        Console.WriteLine("SubPremises: " + record.SubPremises);
        Console.WriteLine("DoubleDependentLocality: " + record.DoubleDependentLocality);
        Console.WriteLine("DependentLocality: " + record.DependentLocality);
        Console.WriteLine("Locality: " + record.Locality);
        Console.WriteLine("SubAdministrativeArea: " + record.SubAdministrativeArea);
        Console.WriteLine("AdministrativeArea: " + record.AdministrativeArea);
        Console.WriteLine("PostalCode: " + record.PostalCode);
        Console.WriteLine("PostalCodeType: " + record.PostalCodeType);
        Console.WriteLine("AddressType: " + record.AddressType);
        Console.WriteLine("AddressKey: " + record.AddressKey);
        Console.WriteLine("SubNationalArea: " + record.SubNationalArea);
        Console.WriteLine("CountryName: " + record.CountryName);
        Console.WriteLine("CountryISO3166_1_Alpha2: " + record.CountryISO3166_1_Alpha2);
        Console.WriteLine("CountryISO3166_1_Alpha3: " + record.CountryISO3166_1_Alpha3);
        Console.WriteLine("CountryISO3166_1_Numeric: " + record.CountryISO3166_1_Numeric);
        Console.WriteLine("CountrySubdivisionCode: " + record.CountrySubdivisionCode);
        Console.WriteLine("Thoroughfare: " + record.Thoroughfare);
        Console.WriteLine("ThoroughfarePreDirection: " + record.ThoroughfarePreDirection);
        Console.WriteLine("ThoroughfareLeadingType: " + record.ThoroughfareLeadingType);
        Console.WriteLine("ThoroughfareName: " + record.ThoroughfareName);
        Console.WriteLine("ThoroughfareTrailingType: " + record.ThoroughfareTrailingType);
        Console.WriteLine("ThoroughfarePostDirection: " + record.ThoroughfarePostDirection);
        Console.WriteLine("DependentThoroughfare: " + record.DependentThoroughfare);
        Console.WriteLine("DependentThoroughfarePreDirection: " + record.DependentThoroughfarePreDirection);
        Console.WriteLine("DependentThoroughfareLeadingType: " + record.DependentThoroughfareLeadingType);
        Console.WriteLine("DependentThoroughfareName: " + record.DependentThoroughfareName);
        Console.WriteLine("DependentThoroughfareTrailingType: " + record.DependentThoroughfareTrailingType);
        Console.WriteLine("DependentThoroughfarePostDirection: " + record.DependentThoroughfarePostDirection);
        Console.WriteLine("Building: " + record.Building);
        Console.WriteLine("PremisesType: " + record.PremisesType);
        Console.WriteLine("PremisesNumber: " + record.PremisesNumber);
        Console.WriteLine("SubPremisesType: " + record.SubPremisesType);
        Console.WriteLine("SubPremisesNumber: " + record.SubPremisesNumber);
        Console.WriteLine("PostBox: " + record.PostBox);
        Console.WriteLine("Latitude: " + record.Latitude);
        Console.WriteLine("Longitude: " + record.Longitude);
        Console.WriteLine("DeliveryIndicator: " + record.DeliveryIndicator);
        Console.WriteLine("MelissaAddressKey: " + record.MelissaAddressKey);
        Console.WriteLine("MelissaAddressKeyBase: " + record.MelissaAddressKeyBase);
        Console.WriteLine("PostOfficeLocation: " + record.PostOfficeLocation);
        Console.WriteLine("SubPremiseLevel: " + record.SubPremiseLevel);
        Console.WriteLine("SubPremiseLevelType: " + record.SubPremiseLevelType);
        Console.WriteLine("SubPremiseLevelNumber: " + record.SubPremiseLevelNumber);
        Console.WriteLine("SubBuilding: " + record.SubBuilding);
        Console.WriteLine("SubBuildingType: " + record.SubBuildingType);
        Console.WriteLine("SubBuildingNumber: " + record.SubBuildingNumber);
        Console.WriteLine("UTC: " + record.UTC);
        Console.WriteLine("DST: " + record.DST);
        Console.WriteLine("DeliveryPointSuffix: " + record.DeliveryPointSuffix);
        Console.WriteLine("CensusKey: " + record.CensusKey);

        // Extras
        Console.WriteLine("CBSACode: " + record.Extras.CBSACode);
        Console.WriteLine("CBSADivisionCode: " + record.Extras.CBSADivisionCode);
        Console.WriteLine("CBSADivisionLevel: " + record.Extras.CBSADivisionLevel);
        Console.WriteLine("CBSADivisionTitle: " + record.Extras.CBSADivisionTitle);
        Console.WriteLine("CBSALevel: " + record.Extras.CBSALevel);
        Console.WriteLine("CBSATitle: " + record.Extras.CBSATitle);
        Console.WriteLine("CarrierRoute: " + record.Extras.CarrierRoute);
        Console.WriteLine("CensusBlock: " + record.Extras.CensusBlock);
        Console.WriteLine("CensusTract: " + record.Extras.CensusTract);
        Console.WriteLine("CongressionalDistrict: " + record.Extras.CongressionalDistrict);
        Console.WriteLine("CountyFIPS: " + record.Extras.CountyFIPS);
        Console.WriteLine("CountySubdivisionCode: " + record.Extras.CountySubdivisionCode);
        Console.WriteLine("CountySubdivisionName: " + record.Extras.CountySubdivisionName);
        Console.WriteLine("DeliveryPointCheckDigit: " + record.Extras.DeliveryPointCheckDigit);
        Console.WriteLine("DeliveryPointCode: " + record.Extras.DeliveryPointCode);
        Console.WriteLine("PlaceCode: " + record.Extras.PlaceCode);
        Console.WriteLine("PlaceName: " + record.Extras.PlaceName);
        Console.WriteLine("StateDistrictLower: " + record.Extras.StateDistrictLower);
        Console.WriteLine("StateDistrictUpper: " + record.Extras.StateDistrictUpper);
        Console.WriteLine("UnifiedSchoolDistrictCode: " + record.Extras.UnifiedSchoolDistrictCode);
        Console.WriteLine("UnifiedSchoolDistrictName: " + record.Extras.UnifiedSchoolDistrictName);
      }
    }
  }
}
