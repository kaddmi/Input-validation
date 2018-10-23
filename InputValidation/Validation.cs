using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace InputValidation
{
    class Validation
    {
        public bool ValidateEmail(string email)
        {
            Match match = Regex.Match(email, @"^([a-z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-z0-9\-]+\.)+))([a-z]{2,4}|[0-9]{1,3})(\]?)$", RegexOptions.IgnoreCase);
            return match.Success;
        }

        public bool ValidateURL(string URL)
        {
            Match match = Regex.Match(URL, @"^((https?|ftp)\://((\[?(\d{1,3}\.){3}\d{1,3}\]?)|(([-a-z0-9]+\.)+[a-zA-Z]{2,4}))(\:\d+)?(/[-a-zA-Z0-9._?,'+&amp;%$#=~\\]+)*/?)$", RegexOptions.IgnoreCase);
            return match.Success;
        }

        public bool ValidatFilePath(string path)
        {
            Match match = Regex.Match(path, @"(?i)^[a-z]:\\[^/:*?<>|]*[^\\]\.(?:exe|doc|txt)$", RegexOptions.IgnoreCase);
            return match.Success;
        }
    }
}
