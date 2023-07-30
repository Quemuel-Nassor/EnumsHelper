# Enums Helper

[About](#about) | [Technology](#technology) | [Installation](#installation) | [Samples](#samples)

[![NuGet](https://img.shields.io/nuget/v/enum-helper?style=flat)](https://www.nuget.org/packages/enum-helper) [![GitHub](https://img.shields.io/github/license/quemuel-nassor/EnumsHelper?color=green&style=flat)](https://github.com/Quemuel-Nassor/EnumsHelper/blob/master/LICENSE.txt) [![Nuget](https://img.shields.io/nuget/dt/enum-helper?color=informational&style=flat)](https://www.nuget.org/packages/enum-helper)

## About
This is tool to assist in searching for enumeration attributes

## Technology

[.NET Standard 2.0](https://learn.microsoft.com/pt-br/dotnet/standard/net-standard?tabs=net-standard-2-0)

## Installation
To install and use this tool, you will need to install the [nuget package](https://www.nuget.org/packages/enum-helper) and register the service in your application settings.

## Samples

```c#
Console.WriteLine($"{(int)DayOfWeek.Monday} - {DayOfWeek.Monday} - {DayOfWeek.Monday.GetFormattedDayOfWeek()}");
//output: "1 - Monday - Segunda-Feira"
```

```c#
public enum PremiationPositionEnum
{
    [Color("Golden", "#ffd700")]
    [Color("AnotherGolder", "#ffd701")]
    [Description("First Place")]
    First = 1,

    [Color("Silver", "#c0c0c0")]
    [Color("AnotherSilver", "#c0c0c1")]
    [Description("Second Place")]
    Second,

    [Color("Bronze", "#cd7f32")]
    [Color("AnotherBronze", "#cd7f33")]
    [Description("Third Place")]
    Third
}

Console.WriteLine($"Position: {PremiationPositionEnum.First} - " +
    $"Description: '{PremiationPositionEnum.First.GetDescription()}' - " +
    $"Medal: '{PremiationPositionEnum.First.GetColor("Golden")}'/"+
    $"'{PremiationPositionEnum.First.GetColor("AnotherGolden")}'");
Console.WriteLine($"Position: {PremiationPositionEnum.Second} - " +
    $"Description: '{PremiationPositionEnum.Second.GetDescription()}' - " +
    $"Medal: '{PremiationPositionEnum.Second.GetColor("Silver")}'/"+
    $"'{PremiationPositionEnum.Second.GetColor("AnotherSilver")}'");
Console.WriteLine($"Position: {PremiationPositionEnum.Third} - " +
    $"Description: '{PremiationPositionEnum.Third.GetDescription()}' - " +
    $"Medal: '{PremiationPositionEnum.Third.GetColor("Bronze")}'/"+
    $"'{PremiationPositionEnum.Third.GetColor("AnotherBronze")}'");

/*output:
Position: First - Description: 'First Place' - Medal: '#ffd700'/'#ffd701'
Position: Second - Description: 'Second Place' - Medal: '#c0c0c0'/'#c0c0c1'
Position: Third - Description: 'Third Place' - Medal: '#cd7f32'/'#cd7f33'
*/
```