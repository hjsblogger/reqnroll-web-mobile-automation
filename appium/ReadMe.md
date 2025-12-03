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

Update the LambdaTest Credentials - [LT_USERNAME](https://github.com/hjsblogger/reqnroll-web-mobile-automation/blob/main/appium/Makefile#L17) and [LT_ACCESS_KEY](https://github.com/hjsblogger/reqnroll-web-mobile-automation/blob/main/appium/Makefile#L18) in Makefile.

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

For the testing, we are using the [Proverbial App (apk)](https://prod-mobile-artefacts.lambdatest.com/assets/docs/proverbial_android.apk) from LambdaTest. The app needs to be uploaded to the LambdaTest cloud storage. Run the below command for uploading the app to the cloud:

Note: Please replace the LT_USERNAME and LT_ACCESS_KEY with the actual LambdaTest crendentials that are available in the [LambdaTest Profile Section](https://accounts.lambdatest.com/security/username-accesskey) section

```bash
curl -u "LT_USERNAME:LT_ACCESS_KEY" -X POST "https://manual-api.lambdatest.com/app/upload/realDevice" -F "url=https://prod-mobile-artefacts.lambdatest.com/assets/docs/proverbial_android.apk" -F "name=proverbial-android" -F "custom_id=sampleName" -F "storage=url" -F "visibility=individual"
```

If the command execution is successful, you would see a APP ID in the command output:

<img width="1413" height="104" alt="Image" src="https://github.com/user-attachments/assets/eb8ae7b8-59ab-4b8e-bb9b-b031e40426fa" />

You would also see the app named 'proverbial-android' in the [App Live App Dashboard](https://applive.lambdatest.com/app)

<img width="1186" height="749" alt="Image" src="https://github.com/user-attachments/assets/50b7db8d-196a-4610-b4b6-e7d5729e0dfe" />

Now that the app is available for testing, let's execute the other make commands

**Step 5**

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

<img width="1290" height="111" alt="Image" src="https://github.com/user-attachments/assets/2702de42-b98e-419d-9333-6c24e4109ffb" />

<img width="692" height="486" alt="Image" src="https://github.com/user-attachments/assets/c0faf126-fde1-4f88-baa2-10956067e130" />

<img width="758" height="485" alt="Image" src="https://github.com/user-attachments/assets/17ecbb03-6395-4654-bebf-e91fc110c51e" />

**Step 7**

Navigate to the [LambdaTest Automation Dashboard](https://automation.lambdatest.com/) to check the status of the test execution. As seen below, all the scenarios that are a part of respective .feature(s) files successfuly executed on LambdaTest.

<img width="1186" height="749" alt="Image" src="https://github.com/user-attachments/assets/0eec55e7-fc55-4d9c-a22d-f0c4f292344b" />

## Have feedback or need assistance?
Feel free to fork the repo and contribute to make it better! Email to [himanshu[dot]sheth[at]gmail[dot]com](mailto:himanshu.sheth@gmail.com) for any queries or ping me on the following social media sites:

<b>LinkedIn</b>: [@hjsblogger](https://linkedin.com/in/hjsblogger)<br/>
<b>Twitter</b>: [@hjsblogger](https://www.twitter.com/hjsblogger)