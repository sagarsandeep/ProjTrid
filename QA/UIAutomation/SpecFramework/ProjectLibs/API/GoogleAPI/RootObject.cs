using System.Collections.Generic;

namespace TRID.ProjectLibs.API.GoogleAPI
{
    public class RootObject
    {
        public List<Result> results { get; set; }
        public string status { get; set; }
    }
}
