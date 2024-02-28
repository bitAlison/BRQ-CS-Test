using LibTrade.Contracts;
using LibTrade.Model;
using System.Collections.Generic;

namespace LibTrade
{
    public class ChainsOfResponsibility
    {
        /// <summary>
        /// Chain of Responsibility Design Pattern
        /// </summary>
        public static IList<TradeCategoryModel> Run(IList<ITrade> Data)
        {
            // Setup Chain of Responsibility
            Handler LowRisk = new LowRisk();
            Handler MediumRisk = new MediumRisk();
            Handler HighRisk = new HighRisk();

            LowRisk.SetSuccessor(MediumRisk);
            MediumRisk.SetSuccessor(HighRisk);

            IList<TradeCategoryModel> Response = new List<TradeCategoryModel>();

            // Process request
            foreach (ITrade model in Data)
            {
                Response.Add(LowRisk.HandleRequest(model.Value, model.ClientSector));
            }
            return Response;
        }
    }

    /// <summary>
    /// The 'Handler' abstract class
    /// </summary>
    public abstract class Handler
    {
        protected Handler successor;
        public void SetSuccessor(Handler successor)
        {
            this.successor = successor;
        }
        public abstract TradeCategoryModel HandleRequest(double value, string sector);
    }

    /// <summary>
    /// The 'LOWRISK' class
    /// </summary>
    public class LowRisk : Handler
    {
        public override TradeCategoryModel HandleRequest(double value, string sector)
        {
            if (sector == "Public")
            {
                if (value >= 0 && value < 1000000)
                {
                    return new TradeCategoryModel()
                    {
                        Value = value,
                        ClientSector = sector,
                        Category = "LOWRISK"
                    };
                }
            }
            return successor.HandleRequest(value, sector);

        }
    }

    /// <summary>
    /// The 'MEDIUMRISK' class
    /// </summary>
    public class MediumRisk : Handler
    {
        public override TradeCategoryModel HandleRequest(double value, string sector)
        {
            if (sector == "Public")
            {
                if (value > 1000000)
                {
                    return new TradeCategoryModel()
                    {
                        Value = value,
                        ClientSector = sector,
                        Category = "MEDIUMRISK"
                    };
                }
            }
            return successor.HandleRequest(value, sector);
        }
    }

    /// <summary>
    /// The 'HIGHRISK' class
    /// </summary>
    public class HighRisk : Handler
    {
        public override TradeCategoryModel HandleRequest(double value, string sector)
        {
            if (sector == "Private")
            {
                if (value > 1000000)
                {
                    return new TradeCategoryModel()
                    {
                        Value = value,
                        ClientSector = sector,
                        Category = "HIGHRISK"
                    };
                }
            }
            return new TradeCategoryModel()
            {
                Value = value,
                ClientSector = sector,
                Category = "UNKNOWN"
            };
            //return successor.HandleRequest(value, sector);
        }
    }
}
