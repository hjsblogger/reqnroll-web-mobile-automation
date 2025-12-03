# Define variables
DOTNET := dotnet
REQNROLL_PROJECT := reqnroll.cloud.sln
PROJECT_NAME := [Appium 2] Reqnroll mobile and web automation

.PHONY: clean
clean:
	@echo "Cleaning up..."
	- $(DOTNET) clean
	- rm -rf bin obj

.PHONY: build
build:
	@echo "Buiding Project..."
	@echo "Set env vars LT_USERNAME & LT_ACCESS_KEY"
	# Procure Username and AccessKey from https://accounts.lambdatest.com/security
	export LT_USERNAME=himanshuj
	export LT_ACCESS_KEY=LT_Eky5
	- $(DOTNET) build $(REQNROLL_PROJECT)

.PHONY: test
reqnroll-automation-test:
	@echo "Running Reqnroll tests on LambdaTest cloud grid..."
	- $(DOTNET) test $(REQNROLL_PROJECT) --logger "console;verbosity=detailed"

.PHONY: help
help:
	@echo ""
	@echo "clean : Clean up temp files"
	@echo "build : Building the Reqnroll automation project"
	@echo "reqnroll-automation-test : Running Reqnroll automation tests on LambdaTest cloud grid"