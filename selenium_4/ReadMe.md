<img width="900" height="500" alt="Image" src="https://github.com/user-attachments/assets/9418dc23-3322-4bd0-a7d6-bea66647a436" />
<div align="center">Image generated using AI</a></div>
<br/>

In this 'Web & Mobile automation with Reqnroll Framework' repo, we have covered the usage of the [Reqnroll Framework](reqnroll.net) to automate tests on the LambdaTest platform.

## Steps for test execution

**Step 1**

Create a virtual environment by triggering the *virtualenv venv* command on the terminal

```bash
virtualenv venv
```
<img width="1418" alt="VirtualEnvironment" src="https://github.com/hjsblogger/web-scraping-with-python/assets/1688653/89beb6af-549f-42ac-a063-e5f715018ef8">

**Step 2**

Navigate the newly created virtual environment by triggering the *source venv/bin/activate* command on the terminal

```bash
source venv/bin/activate
```
**Step 3**

You can fetch the LambdaTest Credentials from the [LambdaTest Profile Section](https://accounts.lambdatest.com/security/username-accesskey) section.

Update the LambdaTest Credentials - [LT_USERNAME](https://github.com/hjsblogger/reqnroll-web-mobile-automation/blob/main/selenium_4/Makefile#L17) and [LT_ACCESS_KEY](https://github.com/hjsblogger/reqnroll-web-mobile-automation/blob/main/selenium_4/Makefile#L18) in Makefile.

Alternatively, you can also export the environment variables *LT_USERNAME* and *LT_ACCESS_KEY* by triggering the following commands on the terminal:

For macOS:

```bash
export LT_USERNAME=LT_USERNAME
export LT_ACCESS_KEY=LT_ACCESS_KEY
```

For Linux:

```bash
export LT_USERNAME=LT_USERNAME
export LT_ACCESS_KEY=LT_ACCESS_KEY
```

For Windows:

```bash
set LT_USERNAME=LT_USERNAME
set LT_ACCESS_KEY=LT_ACCESS_KEY
```

**Step 4**

Run the *make clean* command on the terminal to clean the temporary files

```bash
make clean
```

<img width="1419" height="304" alt="Image" src="https://github.com/user-attachments/assets/77b8bfc6-ba0f-43a0-b2ac-ea341a714b84" />

**Step 5**

Trigger the command ```make build``` on the terminal to build the automation project

<img width="1396" height="346" alt="Image" src="https://github.com/user-attachments/assets/569d7305-5a2f-4dd6-88e4-24226ea08d5c" />

**Step 6.1 - Local Execution**

You can execute the Selenium 4 tests with Reqnroll both locally and on the LambdaTest cloud grid. In order to trigger the tests locally, run the command ```export EXEC_PLATFORM=local``` on the terminal.

Trigger the command ```make reqnroll-automation-test``` to run the Reqnroll tests on the local machine.

<img width="1395" height="167" alt="Image" src="https://github.com/user-attachments/assets/0c59fea1-cf55-4146-a6d1-cbbb7bee0dee" />

<img width="702" height="492" alt="Image" src="https://github.com/user-attachments/assets/06a31c38-2fc4-4c28-a792-c2c1e63562c5" />

**Step 6.2 - Cloud Execution**

Trigger the command ```make reqnroll-automation-test``` to run the Reqnroll tests on the LambdaTest platform

<img width="1006" height="117" alt="Image" src="https://github.com/user-attachments/assets/767513a1-35ca-4aa2-a16a-8952ad83be5a" />

<img width="694" height="496" alt="Image" src="https://github.com/user-attachments/assets/12f70e77-bf6b-4c18-aa2f-9b63cce0f608" />

**Step 7 - Cloud Execution**

Navigate to the [LambdaTest Automation Dashboard](https://automation.lambdatest.com/) to check the status of the test execution:

<img width="1186" height="757" alt="Image" src="https://github.com/user-attachments/assets/ecaa399e-6d2d-4fc3-98e7-a03c8c1c0759" />

As seen below, all the scenarios that are a part of respective .feature(s) files successfuly executed on LambdaTest.

<img width="1186" height="594" alt="Image" src="https://github.com/user-attachments/assets/a17c6bcc-0811-4d55-9d12-93bfb8ab5661" />

<img width="1186" height="754" alt="Image" src="https://github.com/user-attachments/assets/a53a65c2-b7e9-45d1-8769-8e7c7db56cc0" />

## Have feedback or need assistance?
Feel free to fork the repo and contribute to make it better! Email to [himanshu[dot]sheth[at]gmail[dot]com](mailto:himanshu.sheth@gmail.com) for any queries or ping me on the following social media sites:

<b>LinkedIn</b>: [@hjsblogger](https://linkedin.com/in/hjsblogger)<br/>
<b>Twitter</b>: [@hjsblogger](https://www.twitter.com/hjsblogger)