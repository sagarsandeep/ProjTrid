using Newtonsoft.Json;

namespace TRID.Jira.JiraApi
{
    public class Fields
    {
        [JsonProperty("summary")]
        public string summary { get; set; }
        public Project project { get; set; }
        public string description { get; set; }
        public IssueType issuetype { get; set; }
        public Fields()
        {
            project = new Project();
            issuetype = new IssueType();
        }
    }
}
