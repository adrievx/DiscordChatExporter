# DiscordChatExporter

**DiscordChatExporter** is an application that can be used to export message history from any [Discord](https://discord.com) channel to a file.
It works with direct messages, group messages, and server channels, and supports Discord's dialect of markdown as well as most other rich media features.

This fork adds some additional features, removes all of the political bloat and backports to .NET 9 for those that don't want to use the very broken VS2026

## Features

- Cross-platform graphical and command-line interfaces
- Authentication via either a user or a bot token
- Multiple output formats: HTML (dark/light), TXT, CSV, JSON
- Support for markdown, attachments, embeds, emoji, and other rich media features
- File partitioning, date ranges, message filtering, and other export options
- Self-contained exports that can be viewed offline

## My Additions
- Removed political bloat
- .NET 9 backport

## Screenshots

![channel list](.assets/list.png)
![rendered output](.assets/output.png)