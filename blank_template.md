## Exercise: Deploying an Empty Logic App Using the Standard Logic App ARM Template

1. Navigate to the Azure Portal (<http://portal.azure.com>).
1. In the left navigation bar, click the **New** button and then select the **Logic App** option.
    ![New Logic App](media/E1-01.png)
    > You may need to search for the **Logic App** option if it is not listed in your recent choices.
1. In the **Create logic app** blade, fill out the form with the following values:
    - **Name**: BlankLogicApp
    - **Subscription**: Select your current subscription
    - **Resource group**: ARMExercise01
    - **Location**: Select an international datacenter
    - **Log Analytics**: Off
1. Click the **Create** button.
1. While the Logic App is being created, you will see a notification indicating that the deployment has started. Once the deployment has completed, you will see another notification indicating that the deployment is complete with a link to the deployment template.
1. Click the **Microsoft.EmptyWorkflow** link to open the ARM template used to create an Empty Logic App.
    ![Deployment Succeeded Notification](media/E1-02.png)
    > If the notification has disappeared, you can click the **bell** icon to view past notifications.
1. 