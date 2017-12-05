# About
Plugin call `[GKLocalPlayer generateIdentityVerificationSignatureWithCompletionHandler]` (iOS 7.0+) which generates a signature that allows a third party server to authenticate the local player. And invoke callbacks in the target GameObject:
* `OnIdentitySuccess` on success. Contain `<publicKeyURL>;<signature>;<salt>;<timestamp>;`
* `OnIdentityError` on error

For example, signature used in GameCenterConnectRequest on [GameSparks](https://www.gamesparks.com/) backend.

# Install
Just copy `Plugins` folder and `GCIdentity.cs` in Assets (e.g. Assets/GCIdentity) folder.

# License
The MIT License (MIT)

Copyright © 2017 ALEXANDER BIVZYUK

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the “Software”), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED “AS IS”, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
