# Midnight Machination Watcher Bot

This is a discord bot for managing player queueing for games. Its primary use will be for the midnight machinations discord, but it is made with no specific server in mind, so it can be used in other servers too.

## Project setup

The recommended way to work on the project is by using our devcontainer and vscode. Other editors would work fine, but the devcontainer will set up some recommended vscode extensions along with it.

### Discord Bot Key

To pass the discord bot key to the program, we store it as an environment variable. The devcontainer will automatically load an env file in the [devcontainer directory](./.devcontainer), however, the program only checks the current environment, so manually loading/storing variables will work too.

Here is an example of what the .env file (or environment key) should look like:
```sh
DISCORD_TOKEN=<token here>
```