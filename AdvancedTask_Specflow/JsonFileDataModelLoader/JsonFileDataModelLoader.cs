using AdvancedTask_Specflow.Model;
using AdvancedTask_Specflow.Utilities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTask_Specflow.Json_DataModelHelper
{
    public class JsonFileDataModelLoader : CommonDriver
    {
        public void passwordChangeIncorrect_data()
        {

            // Load the JSON file into a data model object.
            PasswordChangeDataModel passwordChangeDataModel = JsonConvert.DeserializeObject<PasswordChangeDataModel>(File.ReadAllText("C:\\Users\\Ivica\\Desktop\\AdvancedTask-Specflow\\AdvancedTask_Specflow\\AdvancedTask_Specflow\\TestData\\passwordChangeIncorrect_data.json"));

            // Pass the data model object to the `newPassword()` method.

            currentNewConfirmPasswordComponentObj.newPassword(passwordChangeDataModel);

        }
        public void EmailAndPassword()
        {

            // Load the JSON file into a data model object.
            Login_JsonDataModel login_JsonDataModel = JsonConvert.DeserializeObject<Login_JsonDataModel>(File.ReadAllText("C:\\Users\\Ivica\\Desktop\\AdvancedTask-Specflow\\AdvancedTask_Specflow\\AdvancedTask_Specflow\\TestData\\loginData.json"));

            // Pass the data model object to the `doSignIn` method.

            loginPage_JsonObj.doSignIn(login_JsonDataModel);

        }
        public void passwordNotMeetTheRequirements()
        {

            // Load the JSON file into a data model object.
            PasswordChangeDataModel passwordChangeDataModel = JsonConvert.DeserializeObject<PasswordChangeDataModel>(File.ReadAllText("C:\\Users\\Ivica\\Desktop\\AdvancedTask-Specflow\\AdvancedTask_Specflow\\AdvancedTask_Specflow\\TestData\\passwordNotMeetRequirements_data.json"));

            // Pass the data model object to the `passworddNotMeetRequirements` method.

            currentNewConfirmPasswordComponentObj.passworddNotMeetRequirements(passwordChangeDataModel);

        }
        public void newPassword_dataJsonDataModel()
        {
            // Load the JSON file into a data model object.
            PasswordChangeDataModel passwordChangeDataModel = JsonConvert.DeserializeObject<PasswordChangeDataModel>(File.ReadAllText("C:\\Users\\Ivica\\Desktop\\AdvancedTask-Specflow\\AdvancedTask_Specflow\\AdvancedTask_Specflow\\TestData\\newPassword_data.json"));

            // Pass the data model object to the `newPassword()` method.

            currentNewConfirmPasswordComponentObj.newPassword(passwordChangeDataModel);

        }
        public void loginDataNewPassword()
        {

            // Load the JSON file into a data model object.
            Login_JsonDataModel login_JsonDataModel = JsonConvert.DeserializeObject<Login_JsonDataModel>(File.ReadAllText("C:\\Users\\Ivica\\Desktop\\AdvancedTask-Specflow\\AdvancedTask_Specflow\\AdvancedTask_Specflow\\TestData\\loginDataNewPassword.json"));
            
            // Pass the data model object to the `doSignIn()` method.
            loginPage_JsonObj.doSignIn(login_JsonDataModel);

        }


    }
}
