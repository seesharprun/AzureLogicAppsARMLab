## Exercise: Sharing a Logic App as an Easily-Deployed ARM Template

In this exercise, we will deploy a template from a GitHub repository using the Azure Portal.

### Deploy a Shared ARM Template

1. Use the following link to view an ARM Template that deploys an Azure Function, a Storage Account and a Logic App that are all integrated: <https://github.com/seesharprun/AzureLogicAppsARMLab/blob/master/azure.deploy.json>.
1. Copy and paste the following URL into your browser window to open the Azure Portal and begin the process of deploying the advanced ARM Template: <https://portal.azure.com/#create/Microsoft.Template/uri/https%3A%2F%2Fraw.githubusercontent.com%2Fseesharprun%2FAzureLogicAppsARMLab%2Fmaster%2Fazure.deploy.json>.
1. In the **Custom deployment** form, provide the following values:
    - **Subscription**: Select your current subscription
    - **Resource group**: ARMExercise03
    - **Location**: Select your closest domestic region
    - **I agree to the terms and conditions stated above**: Checkmark to indicate yes 
    - **Pin to dashboard**: Checkmark to indicate yes 
1. Click the **Purchase** button to deploy the ARM template.
1. Once the deployment is complete, click the **Go to resource group** button to view the deployed resources.
1. In the resource group blade, view the **Deployments** for the resource group.
1. In the latest deployment, copy the value of the **LogicAppTriggerURL** output.
1. Using a HTTP inspector (such as <http://hurl.it>), test the logic app by issuing a HTTP POST to the URL from the last step supplying a JSON object as the body of the request.

### Clean-Up Your Resource Group

1. In the left navigation bar, click the **More Services** button and then select the **Resource groups** option.
    ![Resource Groups](media/E0-01.png)
1. In the **Resource groups** blade, right-click the **ARMExercise03** resource group and select the **Delete resource group** option.
1. In the confirmation blade, enter the name of your resource group (**ARMExercise03**) and then click the **Delete** button.