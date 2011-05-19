using System;

namespace directory_listing
{
  class Program
  {
    //http://codekata.pragprog.com/2007/01/code_kata_one_s.html
    //This kata arose from some discussions we’ve been having at the DFW Practioners meetings. The problem domain is something seemingly simple: pricing goods at supermarkets.

    //Some things in supermarkets have simple prices: this can of beans costs $0.65. Other things have more complex prices. For example:

    //    three for a dollar (so what’s the price if I buy 4, or 5?)
    //    $1.99/pound (so what does 4 ounces cost?)
    //    buy two, get one free (so does the third item have a price?)

    //This kata involves no coding. The exercise is to experiment with various models for representing money and prices that are flexible enough to deal with these (and other) pricing schemes, and at the same time are generally usable (at the checkout, for stock management, order entry, and so on). Spend time considering issues such as:

    //    does fractional money exist?
    //    when (if ever) does rounding take place?
    //    how do you keep an audit trail of pricing decisions (and do you need to)?
    //    are costs and prices the same class of thing?
    //    if a shelf of 100 cans is priced using "buy two, get one free", how do you value the stock?

    //This is an ideal shower-time kata, but be careful. Some of the problems are more subtle than they first appear. I suggest that it might take a couple of weeks worth of showers to exhaust the main alternatives. 
    static void Main(string[] args)
    {
    }


    public class Price
    {
    }

    public class Cost
    {
    }

    public class Item
    {
      public Cost Cost { get; set; }

      public Price determine_price()
      {
        return new Price();
      }
    }

    public class PriceDeterminedByNumberOfItemsDividedBySetPrice : ICanProvideAPrice
    {
      readonly IMeasurement price_measurement;

      public PriceDeterminedByNumberOfItemsDividedBySetPrice(IMeasurement price_measurement)
      {
        this.price_measurement = price_measurement;
      }

      public decimal get_price()
      {
      }
    }

    public class PriceDeterminedByWeight : ICanProvideAPrice
    {
      public decimal get_price()
      {
      }
    }

    public interface ICanProvideAPrice
    {
      decimal get_price();
    }

    public class ThreeForADoller : ICanProvideAPrice
    {
      public decimal get_price()
      {
        return 0.0m;
      }
    }
  }

  internal interface IMeasurement
  {
  }
}
