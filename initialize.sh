dotnet tool install --global autosdk.cli --prerelease

autosdk init \
  HeyGen \
  HeyGenApi \
  https://raw.githubusercontent.com/tryAGI/HeyGen/main/heygen.yaml \
  tryAGI \
  --output .
