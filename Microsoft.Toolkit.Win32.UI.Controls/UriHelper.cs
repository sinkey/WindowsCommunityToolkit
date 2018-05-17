// ******************************************************************
// Copyright (c) Microsoft. All rights reserved.
// This code is licensed under the MIT License (MIT).
// THE CODE IS PROVIDED “AS IS”, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED,
// INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.
// IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM,
// DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT,
// TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH
// THE CODE OR THE USE OR OTHER DEALINGS IN THE CODE.
// ******************************************************************

using System;
using System.Text;
using Microsoft.Toolkit.Win32.UI.Controls.Interop.WinRT;

namespace Microsoft.Toolkit.Win32.UI.Controls
{
    // TODO: Place within WebBrowserUriTypeConverter
    internal static class UriHelper
    {
        private const int MAX_PATH_LENGTH = 2048;
        private const int MAX_SCHEME_LENGTH = 32;
        private const int MAX_URL_LENGTH = MAX_PATH_LENGTH + MAX_SCHEME_LENGTH + 3; /*=sizeof("://")*/

        /// <summary>
        /// Converts a Uniform Resource Identifier (URI) to string.
        /// </summary>
        /// <param name="uri">The Uniform Resource Identifier (URI).</param>
        /// <returns>System.String.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="uri" /> is <see langword="null" /></exception>
        /// <remarks>If the length of the URI exceeds 2048 characters, the first 2048 are returned.</remarks>
        internal static string UriToString(Uri uri)
        {
            if (uri == null)
            {
                throw new ArgumentNullException(nameof(uri));
            }

            return new StringBuilder(
                uri.GetComponents(
                    uri.IsAbsoluteUri ? UriComponents.AbsoluteUri : UriComponents.SerializationInfoString,
                    UriFormat.SafeUnescaped),
                MAX_URL_LENGTH).ToString();
        }

        internal static Uri StringToUri(string source)
        {
            if (string.IsNullOrEmpty(source))
            {
                source = WebViewDefaults.AboutBlank;
            }

            if (Uri.TryCreate(source, UriKind.Absolute, out Uri result))
            {
                return result;
            }

            // Unrecognized URI
            throw new ArgumentException(DesignerUI.E_WEBVIEW_INVALID_URI);
        }
    }
}