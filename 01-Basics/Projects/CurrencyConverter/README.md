# Currency Conversion Software

A console program that converts an amount between EGP, USD, EUR, and GBP.

## Run

Open [CurrencyConverter.slnx](CurrencyConverter.slnx) in Visual Studio, or run:

```bash
dotnet run --project CurrencyConverter.csproj
```

## Conversion flow

![Currency conversion flow](CurrencyConverter.svg)

- [Open the editable Draw.io diagram](CurrencyConverter.drawio)
- [Source code](Program.cs)

## How it works

1. The user selects a source currency and a target currency.
2. The amount is converted to EGP using the selected source rate.
3. The EGP amount is divided by the selected target rate.
4. The result is displayed using the current culture's number formatting.

## Current behavior and limitations

- Fixed example rates: USD = 48.5 EGP, EUR = 52.0 EGP, GBP = 60.0 EGP. They are not live exchange rates.
- Currency choices are validated to the range 1–4.
- The amount is read as `decimal` and must be greater than zero.
- The same source and target currency is allowed and returns the original amount.
- The rates are hard-coded; a real currency converter would need a trusted, regularly updated rate provider.
