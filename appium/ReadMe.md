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

Update the LambdaTest Credentials - [LT_USERNAME](https://github.com/hjsblogger/reqnroll-web-mobile-automation/blob/main/Makefile#L16) and [LT_ACCESS_KEY](https://github.com/hjsblogger/reqnroll-web-mobile-automation/blob/main/Makefile#L16) in Makefile.

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

**Step 6**

Trigger the command ```make reqnroll-automation-test``` to run the Reqnroll tests on the LambdaTest platform

<img width="1411" height="454" alt="Image" src="https://github.com/user-attachments/assets/4a02e4f6-98f6-4a0c-ad1a-4920057653f4" />

<img width="1411" height="409" alt="Image" src="https://github.com/user-attachments/assets/a132c003-64f5-4a71-a8e2-49c173248d9d" />

**Step 7**

Navigate to the [LambdaTest Automation Dashboard](https://automation.lambdatest.com/) to check the status of the test execution:

<img width="1207" height="879" alt="Image" src="https://github.com/user-attachments/assets/f8e86e6e-5b29-444a-88b1-3d72fddb91ba" />

As seen below, all the scenarios that are a part of respective .feature(s) files successfuly executed on LambdaTest.

<img width="1207" height="879" alt="Image" src="https://github.com/user-attachments/assets/5215a914-d670-46b7-9d5a-c75423ba7d37" />

<img width="1207" height="879" alt="Image" src="https://github.com/user-attachments/assets/9dcef43e-0e6c-4d1f-948f-4aff9b4344db" />

## Have feedback or need assistance?
Feel free to fork the repo and contribute to make it better! Email to [himanshu[dot]sheth[at]gmail[dot]com](mailto:himanshu.sheth@gmail.com) for any queries or ping me on the following social media sites:

<b>LinkedIn</b>: [@hjsblogger](https://linkedin.com/in/hjsblogger)<br/>
<b>Twitter</b>: [@hjsblogger](https://www.twitter.com/hjsblogger)