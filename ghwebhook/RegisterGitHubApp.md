# Registering a GitHub App

In this documentation, we will explain how to regiter a GitHub App for this repo usage, but please refer to [Registering a GitHub App](https://docs.github.com/en/apps/creating-github-apps/registering-a-github-app/registering-a-github-app) for the latest information.

1. In the upper-right corner of any page on GitHub, click your profile photo.
1. Navigate to your account settings.
    - Click Your organizations.
    - To the right of the organization, click Settings.
1. In the left sidebar, click <> Developer settings.
1. In the left sidebar, click GitHub Apps.
1. Click New GitHub App.
1. Under "GitHub App name", enter a name for your app. 
1. Optionally, under "Description", type a description of your app. Users and organizations will see this description when they install your app.
1. Under "Homepage URL", type the full URL to your app's website.
1. Under "Permissions", choose the following **Repository** permissions:
    - Administation - Read and write
    - Issues - Read and Write
1. Under "Where can this GitHub App be installed?", select Only on this account
1. Click Create GitHub App.

# Obtain App Id and pem file and install the app

Once you registered the GitHub App, then obtain necessary information.

## Obtain the App ID and pem file
1. Open the registered GitHub App.
1. In the General tab, you can see `App ID`.
1. Update `local.settings.json` for `GitHubApplicationId` variable.
1. Scroll down to priavte keys section and generate a key, that will download the pem file for you.
1. Rename the downloaded pem file to `githubapp.private-key.pem` and move to the project. If you prefer keep the name as it is, update `local.settings.json` for `GitHubApplicationPemFilePath` variable and csproj file to include the pem file. 

## Install the GitHub App
1. Open the registered GitHub App.
1. Select Install App and install it to your organization.