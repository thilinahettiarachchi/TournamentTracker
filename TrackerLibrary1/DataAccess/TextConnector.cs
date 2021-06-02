using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary1.Models;

namespace TrackerLibrary1.DataAccess
{
    public class TextConnector : IDataConnection
    {
        // TODO - Write up the CreatePrize for text files.
        public PrizeModel CreatePrize(PrizeModel model)
        {
            model.ID = 1;
            return model;
        }
    }
}
