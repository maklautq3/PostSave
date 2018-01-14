using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace WindowsFormsApplication2
{
    class HTTPDashboardRequest
    {

       

        public static string Siteauthorization(CookieContainer container)
        {
            try
            {
                const String CorrectAuthText = "Welcome to Dashboard.";
                string resultauthorization;
                string password = "12312313";
                var postData = String.Empty;

                postData += "password=" + password;                            
                var request = (HttpWebRequest)WebRequest.Create("https://museum.moscow.dev.xsf.ximxim.com/dashboard/signin");
                var data = Encoding.ASCII.GetBytes(postData);


                request.ContentType = "application/x-www-form-urlencoded";
                request.Method = "POST";
                request.UserAgent = "Mozila/4.0 (compatible; MSIE 6.0; Windows NT 5.1; SV1; MyIE2";
                request.ContentLength = data.Length;

                request.CookieContainer = container;

                using (var stream = request.GetRequestStream())
                { stream.Write(data, 0, data.Length); }
                var response = (HttpWebResponse)request.GetResponse();
                var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
                if (responseString.Contains(CorrectAuthText))
                {
                    resultauthorization = "Авторизация...Успешно!";
                }
                else
                {
                    resultauthorization = "Авторизация...Не успешно!";
                }
                return resultauthorization;
            }
            catch (WebException e)
            {
                return e.ToString();
            }
           
        }

        public static string FindAnon(String anonID, CookieContainer container, out List<string> ComboboxID, out List<string> ObjID)
        {
            
            string resultobj="";
            const String CorrectAuthText = "anonymous:";
            String url = "https://museum.moscow.dev.xsf.ximxim.com/dashboard/profiles_editor/view?name=&surname=&uid=" + anonID + "&email=&network=anonymous";
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "text/html; charset=utf-8";
            request.UserAgent = "Mozila/4.0 (compatible; MSIE 6.0; Windows NT 5.1; SV1; MyIE2";
            request.CookieContainer = container;
            var response = (HttpWebResponse)request.GetResponse();

            var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
            if (responseString.Contains(CorrectAuthText))
            {
                ComboboxID = ListAnonID(responseString);
                ObjID= ListObjID(responseString);
                return resultobj="Найдено "+ ObjID.Count+" польвателей";
            }
            else
            {
                ComboboxID = ListAnonID(responseString);
                ObjID = ListObjID(responseString);
                return resultobj="Найдено 0 пользователей, измените данные";
            }
        }

        public static string GetTargetAnon(String anonID, CookieContainer container)
        {

            string resultobj = "";
            const String CorrectAuthText = "anonymous:";
            String url = "https://museum.moscow.dev.xsf.ximxim.com/dashboard/profiles_editor/" + anonID + "/edit?network=anonymous";
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "text/html; charset=utf-8";
            request.UserAgent = "Mozila/4.0 (compatible; MSIE 6.0; Windows NT 5.1; SV1; MyIE2";
            request.CookieContainer = container;
            var response = (HttpWebResponse)request.GetResponse();

            var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
            if (responseString.Contains(CorrectAuthText))
            {
                return resultobj;
            }
            else
            {
                return resultobj;
            }
        }

        public static string EditSave(CookieContainer container, String Save, String ObjIDUrl)
        {
            const String CorrectAuthText = "User Profiles Editor";
            var request = (HttpWebRequest)WebRequest.Create("https://museum.moscow.dev.xsf.ximxim.com" + ObjIDUrl);
            var postData = Save;
            var data = Encoding.ASCII.GetBytes(postData);
            request.Method = "POST";
            request.ContentType = "multipart/form-data; boundary=----WebKitFormBoundaryqSVflN08a0RnZNAB";
            request.UserAgent = "Mozila/4.0 (compatible; MSIE 6.0; Windows NT 5.1; SV1; MyIE2";
            request.ContentLength = data.Length;

            request.CookieContainer = container;

            using (var stream = request.GetRequestStream())
            { stream.Write(data, 0, data.Length); }
            var response = (HttpWebResponse)request.GetResponse();
            //string Cookies = response.Cookies["username"].Value;

            var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
            if (responseString.Contains(CorrectAuthText))
            {
                return "Запись успешно добавлена";
            }
            else
            {
                return "Возникла ошибка"+ responseString;
            }
        }


            static public List<string> ListAnonID(String respanswer)
        {
            string tempstring;
            List<string> anonid = new List<string>();

            while (respanswer.IndexOf("anonymous:") != -1)
            {
                tempstring = respanswer;
                int temp = respanswer.IndexOf("anonymous:");
                tempstring = tempstring.Substring(temp + 11);
                respanswer = tempstring;
                tempstring = tempstring.Substring(0, 36);
                anonid.Add(tempstring);
            }
            return anonid;
        }

        static public List<string> ListObjID(String respanswer)
        {
            string tempstring;
            string objstring;
            List<string> objid = new List<string>();

            while (respanswer.IndexOf("network data") != -1)
            {
                tempstring = respanswer;
                int temp = respanswer.IndexOf("network data");
                objstring = tempstring.Substring(temp - 124);
                tempstring=tempstring.Substring(temp+12);
                respanswer = tempstring;
                objstring = objstring.Substring(0, 74);
                objid.Add(objstring);
            }
            return objid;
        }

    }
}
