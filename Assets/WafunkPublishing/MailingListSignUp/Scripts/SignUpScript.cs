using System.Collections;
using System.Text;
using TMPro;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

namespace com.wafunkpublishing
{
    public class SignUpScript : MonoBehaviour
    {
        [SerializeField]
        private TMP_InputField inputName, inputEmail, inputApiKey;
        [SerializeField]
        private Button termsButton;
        [SerializeField]
        private GameObject alertPanel;
        [SerializeField]
        private Sprite[] tickImageSprites = new Sprite[2];
        private Image tickImage;
        private bool isChecked;
        private TMP_Text alertText;
        private readonly string BackendUrl = "https://api.mailerlite.com/api/v2/subscribers";
        private readonly string MissingApiKeyError = "API Key is Missing!";

        public void Start()
        {
            Init();
        }

        private void Init()
        {
            inputApiKey.gameObject.SetActive(false);
            tickImage = termsButton.transform.GetChild(1).GetComponent<Image>();
            alertText = alertPanel.transform.GetChild(0).GetComponent<TMP_Text>();
            alertPanel.SetActive(false);

            if (ApiKeyCheck())
            {
                ShowPrompt(MissingApiKeyError);
            }
        }

        private bool ApiKeyCheck()
        {
            return string.IsNullOrEmpty(inputApiKey.text);
        }

        public void TermsChecked()
        {
            if (isChecked)
            {
                isChecked = false;
                termsButton.GetComponentInChildren<TMP_Text>().color = new Color(1f, 1f, 1f, .5f);
                tickImage.sprite = tickImageSprites[0];
            }
            else if (!isChecked)
            {
                isChecked = true;
                termsButton.GetComponentInChildren<TMP_Text>().color = new Color(1f, 1f, 1f, 1f);
                tickImage.sprite = tickImageSprites[1];
            }
        }

        public void Register()
        {
            var username = inputName.text;
            var email = inputEmail.text;

            var isValidForm = ValidateRegistrationForm();

            if (isValidForm)
            {
                var user = new User(username, email);
                StartCoroutine(RegisterUser(user));
            }
        }

        IEnumerator RegisterUser(User user)
        {
            using (var request = UnityWebRequest.PostWwwForm(BackendUrl, "Post"))
            {
                var userJson = JsonUtility.ToJson(user);

                byte[] body = Encoding.UTF8.GetBytes(userJson);

                var token = inputApiKey.text.TrimEnd();

                request.SetRequestHeader("content-type", "application/json");
                request.SetRequestHeader("x-mailerlite-apikey", token);
                request.uploadHandler = new UploadHandlerRaw(body);
                yield return request.SendWebRequest();

                if (request.result == UnityWebRequest.Result.ConnectionError)
                {
                    ShowPrompt("Check your internet connection and try again!");
                }

                if (request.result != UnityWebRequest.Result.Success)
                {
                    ShowPrompt("Error!");
                }
                else
                {
                    ShowPrompt("Success!");
                }
            }
        }

        private bool ValidateRegistrationForm()
        {
            if (ApiKeyCheck())
            {
                ShowPrompt(MissingApiKeyError);
                return false;
            }

            if (string.IsNullOrEmpty(inputName.text) || string.IsNullOrEmpty(inputEmail.text))
            {
                ShowPrompt("Please fill both fields!");
                return false;
            }

            if (inputEmail.text.IndexOf('@') < 1 || inputEmail.text.IndexOf('.') < 1)
            {
                ShowPrompt("Invalid email!");
                return false;
            }

            if (!isChecked)
            {
                ShowPrompt("Please tick the Terms checkbox!");
                return false;
            }

            return true;
        }

        private void ShowPrompt(string message)
        {
            Debug.Log(message);
            alertText.text = message;
            alertPanel.SetActive(true);
            Invoke(nameof(HidePrompt), 2f);
        }

        private void HidePrompt()
        {
            CancelInvoke(nameof(HidePrompt));
            alertText.text = string.Empty;
            alertPanel.SetActive(false);
        }
    }
}
