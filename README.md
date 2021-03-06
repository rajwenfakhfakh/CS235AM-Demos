
# CS235AM-Demos
Demo Xamarin Android apps for CS235AM at LCC

Note: All these apps are in one repository, so you will
need to download or clone the whole repository even if you
only want code for one app.

## Directory

* __Apps with multiple screens using Intent objects__
  * AgeCalc
  * MathFlashCards- 2 Screens (4 projects)
    * v0: Two activities with just one pair of layouts for portrait orientation
    * v1: Same as v0, but with LaunchMode of FrontActivity set to SingleInstance - this approach is now depricated, use the approach in v0 instead.
    * v2: Uses StartActivityForResult, and overrides OnActivityResult to get a result from a second activity
    * GuessMyNumber (not working yet)
* __Apps that save activity state using OnSaveInstanceState__
  * ClickCounter-SaveState, stores an int in a Bundle object
  * ToDo-SaveInstanceState, uses XmlSerializer to save and restore object state
* __Apps that use a ListActivity__
  * ListActivityDemo-VocabularyParseSectionIndex, 4 projects:
    * CustomAdapterDemo: App with a ListView and a custom adapter class that inherits from BaseAdapter<VocabItem>
    * ListActivity+SimpleAdapter+XmlFile: Custom adapter for List\<IDictionary\<string, object\>\>.  The adapter is populated with data parsed from an XML file.
    * ListActivityDemo: Uses the Android ArrayAdapter class for an array of custom objects
    * ListAndParser: Uses a custom adapter with a section indexer. The adapter is populated with data parsed from a text file.
* __Apps that have both portrait and landscape layouts__
  * RpsLayoutDemo - Rock, Paper, Scissors game - 2 projects:
    * RpsDemo-LinearLayouts
    * RpsDemo-RelativeLayouts
* __Apps that use Fragments__
  * HelloFragment
  * MathFlashCards- Fragments
  		* v2: Uses fragments for large and normal screen sizes and both orientations
    	* v3: Same as v2, but fragments are loaded programmatically instead of statically
  * RpsFragDemo
  * Fragment Demo - Vocab: Uses the ListFragment class rather than fragments defined in .axml
  * FragmentsWalkthrough_port+land - This a modified version of the source code for the Xamarin Fragment Walkthrough. It has been updated to work with the 2017 version of Xamarin.Android and it loads different UI layouts based on orientation rather than screen size.
    * Honeycomb is the project that deomonstrates the use of fragments on devices running Android 3.1 (Honeycomb) or higher.
    * SupportLibFragments is the project that shows how to use fragments with a support package for devices running Android 1.6 (Donut) or higher.
* __Apps that use an SQLite Database and SQLite.Net ORM__
  * DataAccessDemo - Displays stock price history in a ListView
  * DataAccessExercise - built on DataAccessDemo, includes a Spinner, DatePicker and complex queries
* __Apps that consume a WebService__
  * Stocks+WebService - Not finished. Can someone help me find a free Stock price Web Service?
  * Weather-WebServiceDemo - Gets weather data from the [Weather Underground](https://www.wunderground.com/?apiref=5cdccc9428586099) using a REST web service. Android and Console apps both work!
  * Weather-NDFD-WebServiceDemo - Gets weather data from the NOAA NDFD using both SOAP and REST web services. Not working.
* __Apps that demonstrate getting locaiton information__
  * GeolocationDemo
    * FusedLocationProvider - Demonstrates getting location using the Google Play Services Fused Location Provider API
    * XamarinGeolocator - Demonstrates getting location using the Xamarin cross-platform Geolocator plug-in

----

I wrote these apps for use with a class I teach at Lane Community College, CS235AM, Intermediate Mobile Applications Development: Android. Read more about the class and find out how to enroll here: <https://birdsbits.wordpress.com/2014/09/09/xamarin-android-course>

Read the rest of my blog, BirdsBits, here:
<https://birdsbits.wordpress.com>
