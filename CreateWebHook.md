# Create GitHub Organization Webhook

In this documentation, we explain how to register the webhook for this repo to work. Please refer to [About webhooks](https://docs.github.com/en/webhooks/about-webhooks) for the latest information.

# Organization Webhook

GitHub provides several types of webhooks, and we need [Organization Webhook] because it contains the webhook for repository CRUD operations.

1. In the upper-right corner of any page on GitHub, click your profile photo.
1. Click Your organizations.
1. To the right of the organization, click Settings.
1. In the left sidebar, click Webhooks.
1. Click Add webhook.
1. Under "Payload URL", type the URL of the Azure Functions address. You can obtain the URL after you completed the READM.md steps.
1. Select the Content type drop-down menu, and select `application/json`
1. Optionally, under "Secret", type a string to use as a secret key if you use Function level key.
1. Under "Which events would you like to trigger this webhook?", select `Let me select individual events`.
1. Check `Repositories`.
1. Click Add webhook.

## Payload URL

Depending on how you run the Azure Functions, you need to update the URL later.