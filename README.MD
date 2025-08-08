# Example Agent for TotalAgility
This project provides an example TotalAgility package containing a template for a managing or planning agent, which in turn can call other worker or micro agents, as required, to complete its goal.

The agent desgin makes use of standardised input and output interfaces for Agent or Custom LLM type processes, meaning the managing agent can call any worker agent without needing to know specific details of how each worker agent is implemented.

The pattern uses a registry of available worker agents, which are used in the planning step of the managing agent to describe the capabilities of each worker agent. 

This overall pattern is similar to "tool use" via MCP, and indeed the managing agent or worker agents can be called via an MCP Proxy using TotalAgility's OpenAPI REST interface. 

The package was created using TotalAgility 8.1.0.

## Package Contents

### Categories
This package creates a category called ```Example Agent```


