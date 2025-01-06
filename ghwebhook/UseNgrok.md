# Use ngrok as a dev tunnel

When you debug the Azure Function application in your local environment, you need to use a tunnel to redirect the post message from the GitHub webhook to your local computer.

In this documentation, we explain how to use ngrok, but you can use any tool of your choice.

1. Download and setup [ngrok](https://ngrok.com/)
1. Once you completed the setup, run ngrok. 
    ```shell
    ngrok http 7071 --host-header=localhost:7071
    ```
1. Once you run the ngrok, you can obtain the public URL as as ``https://edc4-221-103-215-49.ngrok-free.app``.

Then, the payload address would be ``https://edc4-221-103-215-49.ngrok-free.app/api/github/webhooks``. Use this address for the GitHub App.

The port number varies depending on the environment, but the detaul port is usually 7071. Update the port number to match your environmnent. 

You can run the Azure Function application by either press F5 for debug or `func host start --dotnet-isolated-debug` command.
