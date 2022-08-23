# Getting Started

1. Load the Solution into Visual Studio
2. Run WeatherConversion.Core (This is the API the Client App will communicate with
3. Right Click the WeatherConversionClient Folder > open in Terminal
4. Enter `ng serve` to run the front end Angular App
5. Navigate to http://localhost:4200

#Converting a Temperature

1. Enter the temperature to convert
2. Enter the current temperature's unit in the box below that
3. and the unit you'd like to convert to, in the box below that
4. click the button and the converted result will appear

#Technologies Used

- Angular 12
- .NET 6.0
- Minimal API's
- The Ultimate Temperature Library (to save re-inventing the wheel given that we're not making a better one :D)
- Bootstrap

#FAQs

## Why isn't the History Table working?

I would've loved to have fully implemented this given more time but since the focus was on my approach rather than getting everything perfect, I wanted to focus on the approach.

## Why use a library instead of implementing the algorithms yourself?

I'm a fan of keeping things simple and maintainable - that Library fulfilled that requirement and given my integration tests already compare its results against
the according algorithms, they had already been implemented just not in the place they would be had I not used the library.
