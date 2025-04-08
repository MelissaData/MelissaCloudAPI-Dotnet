using MelissaCloudAPIDotnet.MelissaCloudAPISamples;

namespace MelissaCloudAPIDotnet
{
  public class Program
  {
    public static async Task Main(string[] args)
    {
      /*
       * WELCOME TO THE MELISSA CLOUD API DOTNET
       * 
       * 
       * PLEASE COMMENT AND UNCOMMENT WHICH TESTS YOU WANT TO RUN OR IGNORE
       * PLEASE MAKE SURE TO ENTER YOUR LICENSE KEY AS A PARAMETER TO THE CLOUD API OBJECT YOU WOULD LIKE TO TEST
       * 
       *
       */


      // Test the Global Address Verification Cloud API
      /*--------------------------------------------------*/
      GlobalAddressVerificationSamples globalAddressVerificationTests = new GlobalAddressVerificationSamples("ENTER_LICENSE_KEY");

      globalAddressVerificationTests.GlobalAddressVerificationSetValueSample();
      //globalAddressVerificationTests.GlobalAddressVerificationSetValueSample2();
      //globalAddressVerificationTests.GlobalAddressVerificationSample();
      //await globalAddressVerificationTests.GlobalAddressVerificationAsyncSample();
      //globalAddressVerificationTests.GlobalAddressVerificationBatch1Sample();
      //globalAddressVerificationTests.GlobalAddressVerificationBatch2Sample();
      //await globalAddressVerificationTests.GlobalAddressVerificationBatchAsyncSample();



      // Test the Global Email Cloud API
      /*--------------------------------------------------*/
      //GlobalEmailSamples globalEmailTests = new GlobalEmailSamples("ENTER_LICENSE_KEY");

      //globalEmailTests.GlobalEmailSetValueSample();
      //globalEmailTests.GlobalEmailSetValueSample2();
      //globalEmailTests.GlobalEmailSample();
      //await globalEmailTests.GlobalEmailAsyncSample();
      //globalEmailTests.GlobalEmailBatch1Sample();
      //globalEmailTests.GlobalEmailBatch2Sample();
      //await globalEmailTests.GlobalEmailBatchAsyncSample();



      // Test the Global Name Cloud API
      /*--------------------------------------------------*/
      //GlobalNameSamples globalNameTests = new GlobalNameSamples("ENTER_LICENSE_KEY");

      //globalNameTests.GlobalNameSetValueSample();
      //globalNameTests.GlobalNameSetValueSample2();
      //globalNameTests.GlobalNameSample();
      //await globalNameTests.GlobalNameAsyncSample();
      //globalNameTests.GlobalNameBatch1Sample();
      //globalNameTests.GlobalNameBatch2Sample();
      //await globalNameTests.GlobalNameBatchAsyncSample();



      // Test the Global Phone Cloud API
      /*--------------------------------------------------*/
      //GlobalPhoneSamples globalPhoneTests = new GlobalPhoneSamples("ENTER_LICENSE_KEY");

      //globalPhoneTests.GlobalPhoneSetValueSample();
      //globalPhoneTests.GlobalPhoneSetValueSample2();
      //globalPhoneTests.GlobalPhoneSample();
      //await globalPhoneTests.GlobalPhoneAsyncSample();
      //globalPhoneTests.GlobalPhoneBatch1Sample();
      //globalPhoneTests.GlobalPhoneBatch2Sample();
      //await globalPhoneTests.GlobalPhoneBatchAsyncSample();



      // Test the Global IP Cloud API
      /*--------------------------------------------------*/
      //GlobalIPSamples globalIPTests = new GlobalIPSamples("ENTER_LICENSE_KEY");

      //globalIPTests.GlobalIPSetValueSample();
      //globalIPTests.GlobalIPSetValueSample2();
      //globalIPTests.GlobalIPSample();
      //await globalIPTests.GlobalIPAsyncSample();
      //globalIPTests.GlobalIPBatch1Sample();
      //globalIPTests.GlobalIPBatch2Sample();
      //await globalIPTests.GlobalIPBatchAsyncSample();



      // Test the Business Coder Cloud API
      /*--------------------------------------------------*/
      //BusinessCoderSamples businessCoderTests = new BusinessCoderSamples("ENTER_LICENSE_KEY");

      //businessCoderTests.BusinessCoderSetValueSample();
      //businessCoderTests.BusinessCoderSetValueSample2();
      //businessCoderTests.BusinessCoderSample();
      //await businessCoderTests.BusinessCoderAsyncSample();
      //businessCoderTests.BusinessCoderBatch1Sample();
      //businessCoderTests.BusinessCoderBatch2Sample();
      //await businessCoderTests.BusinessCoderBatchAsyncSample();



      // Test the Personator Consumer Cloud API
      /*--------------------------------------------------*/
      //PersonatorConsumerSamples personatorConsumerTests = new PersonatorConsumerSamples("ENTER_LICENSE_KEY");

      //personatorConsumerTests.PersonatorConsumerSetValueSample();
      //personatorConsumerTests.PersonatorConsumerSetValueSample2();
      //personatorConsumerTests.PersonatorConsumerSample();
      //await personatorConsumerTests.PersonatorConsumerAsyncSample();
      //personatorConsumerTests.PersonatorConsumerBatch1Sample();
      //personatorConsumerTests.PersonatorConsumerBatch2Sample();
      //await personatorConsumerTests.PersonatorConsumerBatchAsyncSample();



      // Test the Personator Identity Cloud API
      /*--------------------------------------------------*/
      //PersonatorIdentitySamples personatorIdentityTests = new PersonatorIdentitySamples("ENTER_LICENSE_KEY");

      //personatorIdentityTests.PersonatorIdentitySetValueSample();
      //personatorIdentityTests.PersonatorIdentitySetValueSample2();
      //personatorIdentityTests.PersonatorIdentitySample();
      //await personatorIdentityTests.PersonatorIdentityAsyncSample();
      //personatorIdentityTests.PersonatorIdentityPostSample();
      //await personatorIdentityTests.PersonatorIdentityPostAsyncSample();



      // Test the Personator Search Cloud API
      /*--------------------------------------------------*/
      //PersonatorSearchSamples personatorSearchTests = new PersonatorSearchSamples("ENTER_LICENSE_KEY");

      //personatorSearchTests.PersonatorSearchSetValueSample();
      //personatorSearchTests.PersonatorSearchSetValueSample2();
      //personatorSearchTests.PersonatorSearchSample();
      //await personatorSearchTests.PersonatorSearchAsyncSample();



      // Test the Property Cloud API
      /*--------------------------------------------------*/
      //PropertySamples propertyTests = new PropertySamples("ENTER_LICENSE_KEY");

      //propertyTests.PropertySample();
      //await propertyTests.PropertyAsyncSample();
      //propertyTests.PropertyPost1Sample();
      //await propertyTests.PropertyPost1AsyncSample();
      //propertyTests.PropertyPost2Sample();
      //await propertyTests.PropertyPost2AsyncSample();
      //propertyTests.PropertyPost3Sample();
      //await propertyTests.PropertyPost3AsyncSample();



      // Test the Global Express Entry Cloud API
      /*--------------------------------------------------*/
      //GlobalExpressEntrySamples globalExpressEntryTests = new GlobalExpressEntrySamples("ENTER_LICENSE_KEY");

      //globalExpressEntryTests.GlobalExpressEntrySetValueSample();
      //globalExpressEntryTests.GlobalExpressEntrySetValueSample2();
      //globalExpressEntryTests.GlobalExpressEntrySample();
      //await globalExpressEntryTests.GlobalExpressEntryAsyncSample();



      // Test the Reverse GeoCoder Cloud API
      /*--------------------------------------------------*/
      //ReverseGeoCoderSamples reverseGeoCoderTests = new ReverseGeoCoderSamples("ENTER_LICENSE_KEY");

      //reverseGeoCoderTests.ReverseGeoCoderSetValueSample();
      //reverseGeoCoderTests.ReverseGeoCoderSample();
      //await reverseGeoCoderTests.ReverseGeoCoderAsyncSample();
      //reverseGeoCoderTests.ReverseGeoCoderPost1Sample();
      //await reverseGeoCoderTests.ReverseGeoCoderPost1AsyncSample();



      // Test the Street Route Cloud API
      /*--------------------------------------------------*/
      //StreetRouteSamples streetRouteTests = new StreetRouteSamples("ENTER_LICENSE_KEY");

      //streetRouteTests.StreetRouteSetValueSample();
      //streetRouteTests.StreetRouteSetValueSample2();
      //streetRouteTests.StreetRouteSample();
      //await streetRouteTests.StreetRouteAsyncSample();
      //streetRouteTests.StreetRouteBatch1Sample();
      //streetRouteTests.StreetRouteBatch2Sample();
      //await streetRouteTests.StreetRouteBatchAsyncSample();



      // Test the SSN Name Match Cloud API
      /*--------------------------------------------------*/
      //SSNNameMatchSamples ssnNameMatchTests = new SSNNameMatchSamples("ENTER_LICENSE_KEY");

      //ssnNameMatchTests.SSNNameMatchSetValueSample();
      //ssnNameMatchTests.SSNNameMatchSetValueSample2();
      //ssnNameMatchTests.SSNNameMatchSample();
      //await ssnNameMatchTests.SSNNameMatchAsyncSample();
      //ssnNameMatchTests.SSNNameMatchBatch1Sample();
      //ssnNameMatchTests.SSNNameMatchBatch2Sample();
      //await ssnNameMatchTests.SSNNameMatchBatchAsyncSample();


      // Test the Smart Mover Cloud API
      /*--------------------------------------------------*/
      //SmartMoverSamples smartMoverTests = new SmartMoverSamples("ENTER_LICENSE_KEY", "ENTER_PAF_ID");

      //smartMoverTests.SmartMoverSetValueSample();
      //smartMoverTests.SmartMoverSetValueSample2();
      //smartMoverTests.SmartMoverSample();
      //await smartMoverTests.SmartMoverAsyncSample();
      //smartMoverTests.SmartMoverBatch1Sample();
      //smartMoverTests.SmartMoverBatch2Sample();
      //await smartMoverTests.SmartMoverBatchAsyncSample();


      // Test the People Business Search Cloud API
      /*--------------------------------------------------*/
      //PeopleBusinessSearchSamples peopleBusinessSearchTests = new PeopleBusinessSearchSamples("ENTER_LICENSE_KEY");

      //peopleBusinessSearchTests.PeopleBusinessSearchSetValueSample();
      //peopleBusinessSearchTests.PeopleBusinessSearchSetValueSample2();
      //peopleBusinessSearchTests.PeopleBusinessSearchSample();
      //await peopleBusinessSearchTests.PeopleBusinessSearchAsyncSample();
    }
  }
}
