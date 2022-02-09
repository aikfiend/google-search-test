Feature: Search Engine

@smoke
Scenario: Google Search
    When I open https://google.com
    And I click I Agree button
    And I click in Search field
    And I type SpecFlow into Search field
    And I click Search button
    Then I see About N results panel is displayed