# MailingListSignUp for Unity Game Engine
This is a simple tool for integrating mailing list tools like MailerLite
The Mailing List Signup Asset is a prefab for adding subscribers to a Mailer Lite mailing list. It is an integration with Mailer Lite’s API which makes audience building easy for Unity game developers.

# How to use
- In [MailerLite](https://www.mailerlite.com/)
  - Set up an account (it’s free)  
  - Create a new API Key
- In Unity
  - Import the [package](https://drive.google.com/file/d/15r0FwAE4vjlHpvKIUMFIjCtpaZBj0ToY/view?usp=drive_link) 
  - Create a new scene
  - Drag the SignUpFormCanvas prefab onto your scene from the Project menu. It is located in Assets/WafunkPublishing/MailingListSignUp/Prefabs
  - Create an empty Game object – your controller - and attach the SignUpScript.cs file to it. It is located in Assets/WafunkPublishing/MailingListSignUp/Scripts
  - Paste your MailerLite API Key into the ApiKeyInputField of the SignUpFormCanvas. Not to worry, it gets hidden when the app is run.
  - Select your controller and drag the NameInputField, EmailInputField, ApiKeyInputField, TermsButton and AlertPanel from the SignUpFormCanvas into the appropriate holders in the Inspector View
  - If you have a Menu Scene or any other scene you'd like to navigate to after a user successfully registers or skips registration, enter its name in the 'Menu Scene' field in the Inspector View
  - Select the 'SkipButton' from the SignUpFormCanvas and set its click method to the 'SignUpScript.SkipRegistration' function
  - Select the 'SubmitButton' from the SignUpFormCanvas and set its click method to the 'SignUpScript.Register' function
  - Select the 'TermsAndConditionsButton' from the SignUpFormCanvas and set its click method to the 'SignUpScript.TermsChecked' function
  - You may also want to edit the TermsAndConditionsText text in the Inspector
- Run the scene to test

# Demo Scene
The DemoScene shows the asset in use. Note that the API Key is currently a dummy one so ensure you replace it with yours as described above.
