using MelissaData.CloudAPI;

namespace MelissaCloudAPIDotnet.MelissaCloudAPISamples
{
  public class PropertySamples
  {
    public string licenseKey;

    public PropertySamples(string licenseKey)
    {
      this.licenseKey = licenseKey;
    }

    /// <summary>
    /// This function uses the Property Cloud API object to make a GET request
    /// Multiple endpoints are tested 
    /// </summary>
    public void PropertySample()
    {
      Property property = new Property(licenseKey);
      property.SetAddressLine1("22382 Avenida Empresa");
      property.SetCity("Rancho Santa Margarita");
      property.SetState("CA");

      string response = property.GetLookupProperty<string>();
      PropertyResponse responseObject = property.GetLookupProperty<PropertyResponse>();

      Console.WriteLine(response);

      Console.WriteLine($"\nVersion: {responseObject.Version}");
      Console.WriteLine($"TransmissionResults: {responseObject.TransmissionResults}");
      Console.WriteLine($"TotalRecords: {responseObject.TotalRecords}\n");
      foreach (var record in responseObject.Records)
      {
        Console.WriteLine("Results: " + record.Results);
        Console.WriteLine($"Parcel: \n" +
          $"  FIPSCode: {record.Parcel.FIPSCode}\n" +
          $"  UnformattedAPN: {record.Parcel.UnformattedAPN}\n" +
          $"  FormattedAPN: {record.Parcel.FormattedAPN}\n");
        Console.WriteLine($"PrimaryOwner: \n" +
          $"  Name1Full: {record.PrimaryOwner.Name1Full}\n");
        Console.WriteLine($"Tax: \n" +
          $"  AssessedValueTotal: {record.Tax.AssessedValueTotal}\n" +
          $"  MarketValueTotal: {record.Tax.MarketValueTotal}\n" +
          $"  TaxFiscalYear: {record.Tax.TaxFiscalYear}\n" +
          $"  TaxBilledAmount: {record.Tax.TaxBilledAmount}\n");
        Console.WriteLine($"SaleInfo: \n" +
          $"  AssessorLastSaleDate: {record.SaleInfo.AssessorLastSaleDate}\n" +
          $"  AssessorLastSaleAmount: {record.SaleInfo.AssessorLastSaleAmount}\n" +
          $"  AssessorPriorSaleDate: {record.SaleInfo.AssessorPriorSaleDate}\n" +
          $"  AssessorPriorSaleAmount: {record.SaleInfo.AssessorPriorSaleAmount}\n" +
          $"  DeedLastSaleDate: {record.SaleInfo.DeedLastSaleDate}\n" +
          $"  DeedLastSalePrice: {record.SaleInfo.DeedLastSalePrice}\n");
        Console.WriteLine($"PropertySize: \n" +
          $"  AreaBuilding: {record.PropertySize.AreaBuilding}\n" +
          $"  AreaLotAcres: {record.PropertySize.AreaLotAcres}\n" +
          $"  AreaLotSF: {record.PropertySize.AreaLotSF}\n");
        Console.WriteLine($"IntRoomInfo: \n" +
          $"  BathCount: {record.IntRoomInfo.BathCount}\n" +
          $"  BedroomsCount: {record.IntRoomInfo.BedroomsCount}\n" +
          $"  RoomsCount: {record.IntRoomInfo.RoomsCount}\n");
      }

      property.Clear();

      property.SetFIPS("06059");
      property.SetAPN("80505208");

      response = property.GetLookupDeeds<string>();
      responseObject = property.GetLookupDeeds<PropertyResponse>();

      Console.WriteLine(response);

      Console.WriteLine($"\nVersion: {responseObject.Version}");
      Console.WriteLine($"TransmissionResults: {responseObject.TransmissionResults}");
      Console.WriteLine($"TotalRecords: {responseObject.TotalRecords}\n");
      foreach (var record in responseObject.Records)
      {
        Console.WriteLine($"DocInfo: \n" +
          $"  RecordingDate: {record.DocInfo.GetRecordingDate()}");
        Console.WriteLine($"TxDefInfo: \n" +
          $"  TransactionType: {record.TxDefInfo.GetTransactionType()}");
        Console.WriteLine($"TxAmtInfo: \n" +
          $"  TransferAmount: {record.TxAmtInfo.GetTransferAmount()}");
        Console.WriteLine($"PrimaryGrantor: \n" +
          $"  Name1Full: {record.PrimaryGrantor.GetName1Full()}\n" +
          $"  Name2Full: {record.PrimaryGrantor.GetName2Full()}");
        Console.WriteLine($"PrimaryGrantee: \n" +
          $"  Name1Full: {record.PrimaryGrantee.GetName1Full()}\n" +
          $"  Name2Full: {record.PrimaryGrantee.GetName2Full()}");
        Console.WriteLine($"TitleCompInfo: \n" +
          $"  StandardizedName: {record.TitleCompInfo.GetStandardizedName()}");
        Console.WriteLine($"Mortgage1: \n" +
          $"  RecordingDate: {record.Mortgage1.GetRecordingDate()}\n" +
          $"  Amount: {record.Mortgage1.Amount}\n" +
          $"  InterestRate {record.Mortgage1.GetInterestRate()}\n");
      }

      property.Clear();

      property.SetMAK("9005381555");

      response = property.GetLookupHomesByOwner<string>();
      responseObject = property.GetLookupHomesByOwner<PropertyResponse>();

      Console.WriteLine(response);

      Console.WriteLine($"\nVersion: {responseObject.Version}");
      Console.WriteLine($"TransmissionResults: {responseObject.TransmissionResults}");
      Console.WriteLine($"TotalRecords: {responseObject.TotalRecords}\n");
      foreach (var record in responseObject.Records)
      {
        Console.WriteLine(
          $"  MAK: {record.MAK}\n" +
          $"  BaseMAK: {record.BaseMAK}\n" +
          $"  FIPS: {record.FIPS}\n" +
          $"  APN: {record.APN}\n" +
          $"  PropertyAddress: {record.PropertyAddress}\n" +
          $"  PropertyCity: {record.PropertyCity}\n" +
          $"  PropertyState: {record.PropertyState}\n" +
          $"  PropertyZip: {record.PropertyZip}\n" +
          $"  PropertyPlus4: {record.PropertyPlus4}\n");
      }
    }

    /// <summary>
    /// This asynchronous function uses the Property Cloud API object to make a GET request
    /// Multiple endpoints are tested 
    /// </summary>
    public async Task PropertyAsyncSample()
    {
      Property property = new Property(licenseKey);
      property.SetAddressLine1("22382 Avenida Empresa");
      property.SetCity("Rancho Santa Margarita");
      property.SetState("CA");

      string response = await property.GetLookupPropertyAsync<string>();
      PropertyResponse responseObject = await property.GetLookupPropertyAsync<PropertyResponse>();

      Console.WriteLine(response);

      Console.WriteLine($"\nVersion: {responseObject.Version}");
      Console.WriteLine($"TransmissionResults: {responseObject.TransmissionResults}");
      Console.WriteLine($"TotalRecords: {responseObject.TotalRecords}\n");
      foreach (var record in responseObject.Records)
      {
        Console.WriteLine("Results: " + record.Results);
        Console.WriteLine($"Parcel: \n" +
          $"  FIPSCode: {record.Parcel.FIPSCode}\n" +
          $"  UnformattedAPN: {record.Parcel.UnformattedAPN}\n" +
          $"  FormattedAPN: {record.Parcel.FormattedAPN}\n");
        Console.WriteLine($"PrimaryOwner: \n" +
          $"  Name1Full: {record.PrimaryOwner.Name1Full}\n");
        Console.WriteLine($"Tax: \n" +
          $"  AssessedValueTotal: {record.Tax.AssessedValueTotal}\n" +
          $"  MarketValueTotal: {record.Tax.MarketValueTotal}\n" +
          $"  TaxFiscalYear: {record.Tax.TaxFiscalYear}\n" +
          $"  TaxBilledAmount: {record.Tax.TaxBilledAmount}\n");
        Console.WriteLine($"SaleInfo: \n" +
          $"  AssessorLastSaleDate: {record.SaleInfo.AssessorLastSaleDate}\n" +
          $"  AssessorLastSaleAmount: {record.SaleInfo.AssessorLastSaleAmount}\n" +
          $"  AssessorPriorSaleDate: {record.SaleInfo.AssessorPriorSaleDate}\n" +
          $"  AssessorPriorSaleAmount: {record.SaleInfo.AssessorPriorSaleAmount}\n" +
          $"  DeedLastSaleDate: {record.SaleInfo.DeedLastSaleDate}\n" +
          $"  DeedLastSalePrice: {record.SaleInfo.DeedLastSalePrice}\n");
        Console.WriteLine($"PropertySize: \n" +
          $"  AreaBuilding: {record.PropertySize.AreaBuilding}\n" +
          $"  AreaLotAcres: {record.PropertySize.AreaLotAcres}\n" +
          $"  AreaLotSF: {record.PropertySize.AreaLotSF}\n");
        Console.WriteLine($"IntRoomInfo: \n" +
          $"  BathCount: {record.IntRoomInfo.BathCount}\n" +
          $"  BedroomsCount: {record.IntRoomInfo.BedroomsCount}\n" +
          $"  RoomsCount: {record.IntRoomInfo.RoomsCount}\n");
      }

      property.Clear();

      property.SetFIPS("06059");
      property.SetAPN("80505208");

      response = await property.GetLookupDeedsAsync<string>();
      responseObject = await property.GetLookupDeedsAsync<PropertyResponse>();

      Console.WriteLine(response);

      Console.WriteLine($"\nVersion: {responseObject.Version}");
      Console.WriteLine($"TransmissionResults: {responseObject.TransmissionResults}");
      Console.WriteLine($"TotalRecords: {responseObject.TotalRecords}\n");
      foreach (var record in responseObject.Records)
      {
        Console.WriteLine($"DocInfo: \n" +
          $"  RecordingDate: {record.DocInfo.GetRecordingDate()}");
        Console.WriteLine($"TxDefInfo: \n" +
          $"  TransactionType: {record.TxDefInfo.GetTransactionType()}");
        Console.WriteLine($"TxAmtInfo: \n" +
          $"  TransferAmount: {record.TxAmtInfo.GetTransferAmount()}");
        Console.WriteLine($"PrimaryGrantor: \n" +
          $"  Name1Full: {record.PrimaryGrantor.GetName1Full()}\n" +
          $"  Name2Full: {record.PrimaryGrantor.GetName2Full()}");
        Console.WriteLine($"PrimaryGrantee: \n" +
          $"  Name1Full: {record.PrimaryGrantee.GetName1Full()}\n" +
          $"  Name2Full: {record.PrimaryGrantee.GetName2Full()}");
        Console.WriteLine($"TitleCompInfo: \n" +
          $"  StandardizedName: {record.TitleCompInfo.GetStandardizedName()}");
        Console.WriteLine($"Mortgage1: \n" +
          $"  RecordingDate: {record.Mortgage1.GetRecordingDate()}\n" +
          $"  Amount: {record.Mortgage1.Amount}\n" +
          $"  InterestRate {record.Mortgage1.GetInterestRate()}\n");
      }

      property.Clear();

      property.SetMAK("9005381555");

      response = await property.GetLookupHomesByOwnerAsync<string>();
      responseObject = await property.GetLookupHomesByOwnerAsync<PropertyResponse>();

      Console.WriteLine(response);

      Console.WriteLine($"\nVersion: {responseObject.Version}");
      Console.WriteLine($"TransmissionResults: {responseObject.TransmissionResults}");
      Console.WriteLine($"TotalRecords: {responseObject.TotalRecords}\n");
      foreach (var record in responseObject.Records)
      {
        Console.WriteLine(
          $"  MAK: {record.MAK}\n" +
          $"  BaseMAK: {record.BaseMAK}\n" +
          $"  FIPS: {record.FIPS}\n" +
          $"  APN: {record.APN}\n" +
          $"  PropertyAddress: {record.PropertyAddress}\n" +
          $"  PropertyCity: {record.PropertyCity}\n" +
          $"  PropertyState: {record.PropertyState}\n" +
          $"  PropertyZip: {record.PropertyZip}\n" +
          $"  PropertyPlus4: {record.PropertyPlus4}\n");
      }
    }

    /// <summary>
    /// This function uses the Property Cloud API object to make a POST request
    /// This tests the lookuphomesbyowner and lookupdeeds endpoints that have a different request structure than the lookupproperty endpoint
    /// Use PropertyPostRequest for these endpoints even though they do not work with BATCH 
    /// </summary>
    public void PropertyPost1Sample()
    {
      Property property = new Property();

      property.SetPostBody(new PropertyPostRequest
      {
        CustomerId = licenseKey,
        FreeForm = "1 Microsoft Way, Redmond, WA 98052"
      });

      string response = property.PostLookupHomesByOwner<string>();
      PropertyResponse responseObject = property.PostLookupHomesByOwner<PropertyResponse>();

      Console.WriteLine(response);

      Console.WriteLine($"\nVersion: {responseObject.Version}");
      Console.WriteLine($"TransmissionResults: {responseObject.TransmissionResults}");
      Console.WriteLine($"TotalRecords: {responseObject.TotalRecords}\n");
      foreach (var record in responseObject.Records)
      {
        Console.WriteLine(
          $"  MAK: {record.MAK}\n" +
          $"  BaseMAK: {record.BaseMAK}\n" +
          $"  FIPS: {record.FIPS}\n" +
          $"  APN: {record.APN}\n" +
          $"  PropertyAddress: {record.PropertyAddress}\n" +
          $"  PropertyCity: {record.PropertyCity}\n" +
          $"  PropertyState: {record.PropertyState}\n" +
          $"  PropertyZip: {record.PropertyZip}\n" +
          $"  PropertyPlus4: {record.PropertyPlus4}\n");
      }


      property.SetPostBody(new PropertyPostRequest
      {
        CustomerId = licenseKey,
        FIPS = "06059",
        APN = "14312308"
      });

      response = property.PostLookupDeeds<string>();
      responseObject = property.PostLookupDeeds<PropertyResponse>();

      Console.WriteLine(response);

      Console.WriteLine($"\nVersion: {responseObject.Version}");
      Console.WriteLine($"TransmissionResults: {responseObject.TransmissionResults}");
      Console.WriteLine($"TotalRecords: {responseObject.TotalRecords}\n");
      foreach (var record in responseObject.Records)
      {
        Console.WriteLine($"DocInfo: \n" +
          $"  RecordingDate: {record.DocInfo.GetRecordingDate()}");
        Console.WriteLine($"TxDefInfo: \n" +
          $"  TransactionType: {record.TxDefInfo.GetTransactionType()}");
        Console.WriteLine($"TxAmtInfo: \n" +
          $"  TransferAmount: {record.TxAmtInfo.GetTransferAmount()}");
        Console.WriteLine($"PrimaryGrantor: \n" +
          $"  Name1Full: {record.PrimaryGrantor.GetName1Full()}\n" +
          $"  Name2Full: {record.PrimaryGrantor.GetName2Full()}");
        Console.WriteLine($"PrimaryGrantee: \n" +
          $"  Name1Full: {record.PrimaryGrantee.GetName1Full()}\n" +
          $"  Name2Full: {record.PrimaryGrantee.GetName2Full()}");
        Console.WriteLine($"TitleCompInfo: \n" +
          $"  StandardizedName: {record.TitleCompInfo.GetStandardizedName()}");
        Console.WriteLine($"Mortgage1: \n" +
          $"  RecordingDate: {record.Mortgage1.GetRecordingDate()}\n" +
          $"  Amount: {record.Mortgage1.Amount}\n" +
          $"  InterestRate {record.Mortgage1.GetInterestRate()}\n");
      }
    }

    /// <summary>
    /// This asynchronous function uses the Property Cloud API object to make a POST request
    /// This tests the lookuphomesbyowner and lookupdeeds endpoints that have a different request structure than the lookupproperty endpoint
    /// Use PropertyPostRequest for these endpoints even though they do not work with BATCH 
    /// </summary>
    public async Task PropertyPost1AsyncSample()
    {
      Property property = new Property();

      property.SetPostBody(new PropertyPostRequest
      {
        CustomerId = licenseKey,
        FreeForm = "1 Microsoft Way, Redmond, WA 98052"
      });

      string response = await property.PostLookupHomesByOwnerAsync<string>();
      PropertyResponse responseObject = await property.PostLookupHomesByOwnerAsync<PropertyResponse>();

      Console.WriteLine(response);

      Console.WriteLine($"\nVersion: {responseObject.Version}");
      Console.WriteLine($"TransmissionResults: {responseObject.TransmissionResults}");
      Console.WriteLine($"TotalRecords: {responseObject.TotalRecords}\n");
      foreach (var record in responseObject.Records)
      {
        Console.WriteLine(
          $"  MAK: {record.MAK}\n" +
          $"  BaseMAK: {record.BaseMAK}\n" +
          $"  FIPS: {record.FIPS}\n" +
          $"  APN: {record.APN}\n" +
          $"  PropertyAddress: {record.PropertyAddress}\n" +
          $"  PropertyCity: {record.PropertyCity}\n" +
          $"  PropertyState: {record.PropertyState}\n" +
          $"  PropertyZip: {record.PropertyZip}\n" +
          $"  PropertyPlus4: {record.PropertyPlus4}\n");
      }


      property.SetPostBody(new PropertyPostRequest
      {
        CustomerId = licenseKey,
        FIPS = "06059",
        APN = "14312308"
      });

      response = await property.PostLookupDeedsAsync<string>();
      responseObject = await property.PostLookupDeedsAsync<PropertyResponse>();

      Console.WriteLine(response);

      Console.WriteLine($"\nVersion: {responseObject.Version}");
      Console.WriteLine($"TransmissionResults: {responseObject.TransmissionResults}");
      Console.WriteLine($"TotalRecords: {responseObject.TotalRecords}\n");
      foreach (var record in responseObject.Records)
      {
        Console.WriteLine($"DocInfo: \n" +
          $"  RecordingDate: {record.DocInfo.GetRecordingDate()}");
        Console.WriteLine($"TxDefInfo: \n" +
          $"  TransactionType: {record.TxDefInfo.GetTransactionType()}");
        Console.WriteLine($"TxAmtInfo: \n" +
          $"  TransferAmount: {record.TxAmtInfo.GetTransferAmount()}");
        Console.WriteLine($"PrimaryGrantor: \n" +
          $"  Name1Full: {record.PrimaryGrantor.GetName1Full()}\n" +
          $"  Name2Full: {record.PrimaryGrantor.GetName2Full()}");
        Console.WriteLine($"PrimaryGrantee: \n" +
          $"  Name1Full: {record.PrimaryGrantee.GetName1Full()}\n" +
          $"  Name2Full: {record.PrimaryGrantee.GetName2Full()}");
        Console.WriteLine($"TitleCompInfo: \n" +
          $"  StandardizedName: {record.TitleCompInfo.GetStandardizedName()}");
        Console.WriteLine($"Mortgage1: \n" +
          $"  RecordingDate: {record.Mortgage1.GetRecordingDate()}\n" +
          $"  Amount: {record.Mortgage1.Amount}\n" +
          $"  InterestRate {record.Mortgage1.GetInterestRate()}\n");
      }
    }

    /// <summary>
    /// This function uses the Property Cloud API object to make a POST BATCH request
    /// This function showcases method 1 of setting and making POST requests: construct the POST body structure using the Cloud API's respective PostRequest class
    /// </summary>
    public void PropertyPost2Sample()
    {
      Property property = new Property();

      property.SetPostBody(new PropertyPostRequest
      {
        CustomerId = licenseKey,
        TotalRecords = "2",
        Records = new List<PropertyRecordRequest>
        {
          new PropertyRecordRequest
          {
            RecordId = "1",
            AddressLine1 = "22382 Avenida Empresa",
            City = "RSM",
            State = "CA",
            PostalCode = "92688"
          },
          new PropertyRecordRequest
          {
            RecordId = "2",
            AddressLine1 = "710 Winston Ln",
            City = "Sugar Land",
            State = "TX",
            PostalCode = "77479"
          }
        }
      });

      string response = property.PostLookupProperty<string>();
      PropertyResponse responseObject = property.PostLookupProperty<PropertyResponse>();

      Console.WriteLine(response);

      Console.WriteLine($"\nVersion: {responseObject.Version}");
      Console.WriteLine($"TransmissionResults: {responseObject.TransmissionResults}");
      Console.WriteLine($"TotalRecords: {responseObject.TotalRecords}\n");
      foreach (var record in responseObject.Records)
      {
        Console.WriteLine("RecordID: " + record.RecordID);
        Console.WriteLine("Results: " + record.Results);
        Console.WriteLine($"Parcel: \n" +
          $"  FIPSCode: {record.Parcel.FIPSCode}\n" +
          $"  UnformattedAPN: {record.Parcel.UnformattedAPN}\n" +
          $"  FormattedAPN: {record.Parcel.FormattedAPN}\n");
        Console.WriteLine($"PrimaryOwner: \n" +
          $"  Name1Full: {record.PrimaryOwner.Name1Full}\n");
        Console.WriteLine($"Tax: \n" +
          $"  AssessedValueTotal: {record.Tax.AssessedValueTotal}\n" +
          $"  MarketValueTotal: {record.Tax.MarketValueTotal}\n" +
          $"  TaxFiscalYear: {record.Tax.TaxFiscalYear}\n" +
          $"  TaxBilledAmount: {record.Tax.TaxBilledAmount}\n");
        Console.WriteLine($"SaleInfo: \n" +
          $"  AssessorLastSaleDate: {record.SaleInfo.AssessorLastSaleDate}\n" +
          $"  AssessorLastSaleAmount: {record.SaleInfo.AssessorLastSaleAmount}\n" +
          $"  AssessorPriorSaleDate: {record.SaleInfo.AssessorPriorSaleDate}\n" +
          $"  AssessorPriorSaleAmount: {record.SaleInfo.AssessorPriorSaleAmount}\n" +
          $"  DeedLastSaleDate: {record.SaleInfo.DeedLastSaleDate}\n" +
          $"  DeedLastSalePrice: {record.SaleInfo.DeedLastSalePrice}\n");
        Console.WriteLine($"PropertySize: \n" +
          $"  AreaBuilding: {record.PropertySize.AreaBuilding}\n" +
          $"  AreaLotAcres: {record.PropertySize.AreaLotAcres}\n" +
          $"  AreaLotSF: {record.PropertySize.AreaLotSF}\n");
        Console.WriteLine($"IntRoomInfo: \n" +
          $"  BathCount: {record.IntRoomInfo.BathCount}\n" +
          $"  BedroomsCount: {record.IntRoomInfo.BedroomsCount}\n" +
          $"  RoomsCount: {record.IntRoomInfo.RoomsCount}\n");
      }
    }

    /// <summary>
    /// This asynchronous function uses the Property Cloud API object to make a POST BATCH request
    /// This function showcases method 1 of setting and making POST requests: construct the POST body structure using the Cloud API's respective PostRequest class
    /// </summary>
    public async Task PropertyPost2AsyncSample()
    {
      Property property = new Property();

      property.SetPostBody(new PropertyPostRequest
      {
        CustomerId = licenseKey,
        TotalRecords = "2",
        Records = new List<PropertyRecordRequest>
        {
          new PropertyRecordRequest
          {
            RecordId = "1",
            AddressLine1 = "22382 Avenida Empresa",
            City = "RSM",
            State = "CA",
            PostalCode = "92688"
          },
          new PropertyRecordRequest
          {
            RecordId = "2",
          AddressLine1 = "710 Winston Ln",
          City = "Sugar Land",
          State = "TX",
          PostalCode = "77479"
          }
        }
      });

      string response = await property.PostLookupPropertyAsync<string>();
      PropertyResponse responseObject = await property.PostLookupPropertyAsync<PropertyResponse>();

      Console.WriteLine(response);

      Console.WriteLine($"\nVersion: {responseObject.Version}");
      Console.WriteLine($"TransmissionResults: {responseObject.TransmissionResults}");
      Console.WriteLine($"TotalRecords: {responseObject.TotalRecords}\n");
      foreach (var record in responseObject.Records)
      {
        Console.WriteLine("RecordID: " + record.RecordID);
        Console.WriteLine("Results: " + record.Results);
        Console.WriteLine($"Parcel: \n" +
          $"  FIPSCode: {record.Parcel.FIPSCode}\n" +
          $"  UnformattedAPN: {record.Parcel.UnformattedAPN}\n" +
          $"  FormattedAPN: {record.Parcel.FormattedAPN}\n");
        Console.WriteLine($"PrimaryOwner: \n" +
          $"  Name1Full: {record.PrimaryOwner.Name1Full}\n");
        Console.WriteLine($"Tax: \n" +
          $"  AssessedValueTotal: {record.Tax.AssessedValueTotal}\n" +
          $"  MarketValueTotal: {record.Tax.MarketValueTotal}\n" +
          $"  TaxFiscalYear: {record.Tax.TaxFiscalYear}\n" +
          $"  TaxBilledAmount: {record.Tax.TaxBilledAmount}\n");
        Console.WriteLine($"SaleInfo: \n" +
          $"  AssessorLastSaleDate: {record.SaleInfo.AssessorLastSaleDate}\n" +
          $"  AssessorLastSaleAmount: {record.SaleInfo.AssessorLastSaleAmount}\n" +
          $"  AssessorPriorSaleDate: {record.SaleInfo.AssessorPriorSaleDate}\n" +
          $"  AssessorPriorSaleAmount: {record.SaleInfo.AssessorPriorSaleAmount}\n" +
          $"  DeedLastSaleDate: {record.SaleInfo.DeedLastSaleDate}\n" +
          $"  DeedLastSalePrice: {record.SaleInfo.DeedLastSalePrice}\n");
        Console.WriteLine($"PropertySize: \n" +
          $"  AreaBuilding: {record.PropertySize.AreaBuilding}\n" +
          $"  AreaLotAcres: {record.PropertySize.AreaLotAcres}\n" +
          $"  AreaLotSF: {record.PropertySize.AreaLotSF}\n");
        Console.WriteLine($"IntRoomInfo: \n" +
          $"  BathCount: {record.IntRoomInfo.BathCount}\n" +
          $"  BedroomsCount: {record.IntRoomInfo.BedroomsCount}\n" +
          $"  RoomsCount: {record.IntRoomInfo.RoomsCount}\n");
      }
    }

    /// <summary>
    /// This function uses the Property Cloud API object to make a POST BATCH request
    /// This function showcases method 2 of setting and making POST requests: construct the POST body record by using the Cloud API's respective RecordRequest class
    /// </summary>
    public void PropertyPost3Sample()
    {
      Property property = new Property(licenseKey);
      property.SetTotalRecords("2");
      property.AddRecord(
        new PropertyRecordRequest
        {
          RecordId = "1",
          AddressLine1 = "22382 Avenida Empresa",
          City = "RSM",
          State = "CA",
          PostalCode = "92688"
        });
      property.AddRecord(
        new PropertyRecordRequest
        {
          RecordId = "2",
          AddressLine1 = "710 Winston Ln",
          City = "Sugar Land",
          State = "TX",
          PostalCode = "77479"
        });

      string response = property.PostLookupProperty<string>();
      PropertyResponse responseObject = property.PostLookupProperty<PropertyResponse>();

      Console.WriteLine(response);

      Console.WriteLine($"\nVersion: {responseObject.Version}");
      Console.WriteLine($"TransmissionResults: {responseObject.TransmissionResults}");
      Console.WriteLine($"TotalRecords: {responseObject.TotalRecords}\n");
      foreach (var record in responseObject.Records)
      {
        Console.WriteLine("RecordID: " + record.RecordID);
        Console.WriteLine("Results: " + record.Results);
        Console.WriteLine($"Parcel: \n" +
          $"  FIPSCode: {record.Parcel.FIPSCode}\n" +
          $"  UnformattedAPN: {record.Parcel.UnformattedAPN}\n" +
          $"  FormattedAPN: {record.Parcel.FormattedAPN}\n");
        Console.WriteLine($"PrimaryOwner: \n" +
          $"  Name1Full: {record.PrimaryOwner.Name1Full}\n");
        Console.WriteLine($"Tax: \n" +
          $"  AssessedValueTotal: {record.Tax.AssessedValueTotal}\n" +
          $"  MarketValueTotal: {record.Tax.MarketValueTotal}\n" +
          $"  TaxFiscalYear: {record.Tax.TaxFiscalYear}\n" +
          $"  TaxBilledAmount: {record.Tax.TaxBilledAmount}\n");
        Console.WriteLine($"SaleInfo: \n" +
          $"  AssessorLastSaleDate: {record.SaleInfo.AssessorLastSaleDate}\n" +
          $"  AssessorLastSaleAmount: {record.SaleInfo.AssessorLastSaleAmount}\n" +
          $"  AssessorPriorSaleDate: {record.SaleInfo.AssessorPriorSaleDate}\n" +
          $"  AssessorPriorSaleAmount: {record.SaleInfo.AssessorPriorSaleAmount}\n" +
          $"  DeedLastSaleDate: {record.SaleInfo.DeedLastSaleDate}\n" +
          $"  DeedLastSalePrice: {record.SaleInfo.DeedLastSalePrice}\n");
        Console.WriteLine($"PropertySize: \n" +
          $"  AreaBuilding: {record.PropertySize.AreaBuilding}\n" +
          $"  AreaLotAcres: {record.PropertySize.AreaLotAcres}\n" +
          $"  AreaLotSF: {record.PropertySize.AreaLotSF}\n");
        Console.WriteLine($"IntRoomInfo: \n" +
          $"  BathCount: {record.IntRoomInfo.BathCount}\n" +
          $"  BedroomsCount: {record.IntRoomInfo.BedroomsCount}\n" +
          $"  RoomsCount: {record.IntRoomInfo.RoomsCount}\n");
      }
    }


    /// <summary>
    /// This asynchronous function uses the Property Cloud API object to make a POST BATCH request
    /// This function showcases method 2 of setting and making POST requests: construct the POST body record by using the Cloud API's respective RecordRequest class
    /// </summary>
    public async Task PropertyPost3AsyncSample()
    {
      Property property = new Property(licenseKey);
      property.SetTotalRecords("2");
      property.AddRecord(
        new PropertyRecordRequest
        {
          RecordId = "1",
          AddressLine1 = "22382 Avenida Empresa",
          City = "RSM",
          State = "CA",
          PostalCode = "92688"
        });
      property.AddRecord(
        new PropertyRecordRequest
        {
          RecordId = "2",
          AddressLine1 = "710 Winston Ln",
          City = "Sugar Land",
          State = "TX",
          PostalCode = "77479"
        });

      string response = await property.PostLookupPropertyAsync<string>();
      PropertyResponse responseObject = await property.PostLookupPropertyAsync<PropertyResponse>();

      Console.WriteLine(response);

      Console.WriteLine($"\nVersion: {responseObject.Version}");
      Console.WriteLine($"TransmissionResults: {responseObject.TransmissionResults}");
      Console.WriteLine($"TotalRecords: {responseObject.TotalRecords}\n");
      foreach (var record in responseObject.Records)
      {
        Console.WriteLine("RecordID: " + record.RecordID);
        Console.WriteLine("Results: " + record.Results);
        Console.WriteLine($"Parcel: \n" +
          $"  FIPSCode: {record.Parcel.FIPSCode}\n" +
          $"  UnformattedAPN: {record.Parcel.UnformattedAPN}\n" +
          $"  FormattedAPN: {record.Parcel.FormattedAPN}\n");
        Console.WriteLine($"PrimaryOwner: \n" +
          $"  Name1Full: {record.PrimaryOwner.Name1Full}\n");
        Console.WriteLine($"Tax: \n" +
          $"  AssessedValueTotal: {record.Tax.AssessedValueTotal}\n" +
          $"  MarketValueTotal: {record.Tax.MarketValueTotal}\n" +
          $"  TaxFiscalYear: {record.Tax.TaxFiscalYear}\n" +
          $"  TaxBilledAmount: {record.Tax.TaxBilledAmount}\n");
        Console.WriteLine($"SaleInfo: \n" +
          $"  AssessorLastSaleDate: {record.SaleInfo.AssessorLastSaleDate}\n" +
          $"  AssessorLastSaleAmount: {record.SaleInfo.AssessorLastSaleAmount}\n" +
          $"  AssessorPriorSaleDate: {record.SaleInfo.AssessorPriorSaleDate}\n" +
          $"  AssessorPriorSaleAmount: {record.SaleInfo.AssessorPriorSaleAmount}\n" +
          $"  DeedLastSaleDate: {record.SaleInfo.DeedLastSaleDate}\n" +
          $"  DeedLastSalePrice: {record.SaleInfo.DeedLastSalePrice}\n");
        Console.WriteLine($"PropertySize: \n" +
          $"  AreaBuilding: {record.PropertySize.AreaBuilding}\n" +
          $"  AreaLotAcres: {record.PropertySize.AreaLotAcres}\n" +
          $"  AreaLotSF: {record.PropertySize.AreaLotSF}\n");
        Console.WriteLine($"IntRoomInfo: \n" +
          $"  BathCount: {record.IntRoomInfo.BathCount}\n" +
          $"  BedroomsCount: {record.IntRoomInfo.BedroomsCount}\n" +
          $"  RoomsCount: {record.IntRoomInfo.RoomsCount}\n");
      }
    }
  }
}
