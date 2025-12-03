Feature: [Appium 2] Perform actions in Proverbial App

@operations
Scenario: @F1: Validate all UI actions in the Proverbial App
    When I toggle the text color
    And I change the text using the text button
    And I trigger the toast message
    And I tap the notification button
    And I open the geolocation screen
    And I return back to the home screen
    And I open the speed test screen
    And I return back to the home screen
    And I open the in-app browser
    And I enter the url "https://www.lambdatest.com"
    Then the url should be entered successfully