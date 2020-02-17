using System;
using System.Collections.Generic;

namespace SplunkNess.Models
{
    /// <summary>
    /// From splunk this was `sourcetype=frendredirect_logger`
    /// </summary>
    public class FrendRedirectLoggerModels
    {
        public bool preview { get; set; }
        public Result result { get; set; }
    }

    public class Result
    {
        public string _raw { get; set; }
        public DateTime _time { get; set; }
        public string data_centre { get; set; }
        public string date_hour { get; set; }
        public string date_mday { get; set; }
        public string date_minute { get; set; }
        public string date_month { get; set; }
        public string date_second { get; set; }
        public string date_wday { get; set; }
        public string date_year { get; set; }
        public string date_zone { get; set; }
        public List<string> eventtype { get; set; }
        public string fromUrl { get; set; }
        public string hasClassicPreferenceSet { get; set; }
        public string host { get; set; }
        public string index { get; set; }
        public string linecount { get; set; }
        public string memberId { get; set; }
        public string parserUsed { get; set; }
        public string punct { get; set; }
        public string redirectId { get; set; }
        public string redirectOutcome { get; set; }
        public string source { get; set; }
        public string sourcetype { get; set; }
        public string splunk_server { get; set; }
        public string tag { get; set; }
        //public string __invalid_name__tag::host { get; set; }
        public string time { get; set; }
        public string timeendpos { get; set; }
        public string timestartpos { get; set; }
        public string toUrl { get; set; }
        public string userAgent { get; set; }
        public string wasBetterOnFrEnd { get; set; }
        public string wasRedirected { get; set; }
    }
}
