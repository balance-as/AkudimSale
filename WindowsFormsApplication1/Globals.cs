using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Resources;
using System.Collections;
using System.Globalization;
using WindowsFormsApplication1.WarehouseService;


namespace WindowsFormsApplication1
{
    static class Globals
    {
        private static string LocationCode = "";
        private static string UserID = "";
        private static string WinLogon = "";
        private static string SalesPersonCode = "";
        private static string TransferTemplateName = "";
        private static string TransferBatchName = "";
        private static string PhysInvTemplateName = "";
        private static string PhysInvBatchName = "";
        private static string ConsumptionTemplateName = "";
        private static string ConsumptionBatchName = "";
        private static string OutputTemplateName = "";
        private static string OutputBatchName = "";
        private static string EmpLanguageCode = "";
        private static int EmpLanguageID = 0;
        private static string EmpLanguageNav = "";
        private static bool ShowMessage = true;
        private static string ErrorSoundPath = "";
        private static string OkSoundPath = "";
        public static int step = 0;
        public static bool PrintNewPid = false;
        public static bool PrintInvPid = false;
        public static string Password = "";

        public static string theLocation
        {
            get { return LocationCode; }
            set { LocationCode = value; }
        }
        public static string theUserID
        {
            get { return UserID; }
            set { UserID = value; }
        }
        public static string theWinlogon
        {
            get { return WinLogon; }
            set { WinLogon = value; }
        }
        public static string theSalesPersonCode
        {
            get { return SalesPersonCode; }
            set { SalesPersonCode = value; }
        }

        public static string theTransferTemplateName
        {
            get { return TransferTemplateName; }
            set { TransferTemplateName = value; }
        }
        public static string theTransferBatchName
        {
            get { return TransferBatchName; }
            set { TransferBatchName = value; }
        }
        public static string thePhysInvTemplateName
        {
            get { return PhysInvTemplateName; }
            set { PhysInvTemplateName = value; }
        }
        public static string thePhysInvBatchName
        {
            get { return PhysInvBatchName; }
            set { PhysInvBatchName = value; }
        }
        public static string theConsumptionTemplateName
        {
            get { return ConsumptionTemplateName; }
            set { ConsumptionTemplateName = value; }
        }
        public static string theConsumptionBatchName
        {
            get { return ConsumptionBatchName; }
            set { ConsumptionBatchName = value; }
        }
        public static string theOutputTemplateName
        {
            get { return OutputTemplateName; }
            set { OutputTemplateName = value; }
        }
        public static string theOutputBatchName
        {
            get { return OutputBatchName; }
            set { OutputBatchName = value; }
        }
        public static string theLanguageCode
        {
            get { return EmpLanguageCode; }
            set { EmpLanguageCode = value; }
        }
        public static int theLanguageID
        {
            get { return EmpLanguageID; }
            set { EmpLanguageID = value; }
        }
        public static string theLanguageCodeNav
        {
            get { return EmpLanguageNav; }
            set { EmpLanguageNav = value; }
        }
        public static int GlobalStep
        {
            get { return step; }
            set { step = value; }
        }
        public static bool theShowMessage
        {
            get { return ShowMessage; }
            set { ShowMessage = value; }
        }
        public static string theErrorSound
        {
            get { return ErrorSoundPath; }
            set { ErrorSoundPath = value; }
        }
        public static string theOkSoundPath
        {
            get { return OkSoundPath; }
            set { OkSoundPath = value; }
        }
        public static bool thePrintNewPid
        {
            get { return PrintNewPid; }
            set { PrintNewPid = value; }
        }
        public static bool thePrintInvPid
        {
            get { return PrintInvPid; }
            set { PrintInvPid = value; }
        }
        public static string thePassword
        {
            get { return Password; }
            set { Password = value; }
        }
    }



    public class MyToolbox
    {
        public string ReadResFile(string key)
        {
            string resourceValue = string.Empty;
            string file = "";
            switch (Globals.theLanguageCode)
            {
                case "da-DK": file = "Message.da-DK.resx";
                    break;
                case "de-DE": file = "Message.de-DE.resx";
                    break;
                case "en-US": file = "Message.en-US.resx";
                    break;
            }
            if (file != "")
            {
                try
                {
                    ResXResourceReader r = new ResXResourceReader(file);
                    IDictionaryEnumerator en = r.GetEnumerator();
                    while (en.MoveNext())
                    {
                        if (en.Key.Equals(key))
                        {
                            return resourceValue = en.Value.ToString();
                        }
                    }
                    r.Close();
                    return "";
                }
                catch (Exception)
                {
                    throw;
                }
            }
            return "";
        }

        public string ReadEnuResFile(string key)
        {
            string resourceValue = string.Empty;
            string file = "";
            switch (Globals.theLanguageCode)
            {
                case "da-DK": file = "Enum.da-DK.resx";
                    break;
                case "de-DE": file = "Enum.de-DE.resx";
                    break;
                case "en-US": file = "Enum.en-US.resx";
                    break;
            }
            if (file != "")
            {
                try
                {
                    ResXResourceReader r = new ResXResourceReader(file);
                    IDictionaryEnumerator en = r.GetEnumerator();
                    while (en.MoveNext())
                    {
                        if (en.Key.Equals(key))
                        {
                            return resourceValue = en.Value.ToString();
                        }
                    }
                    r.Close();
                    return "";
                }
                catch (Exception)
                {
                    throw;
                }
            }
            return "";
        }
    }
}
