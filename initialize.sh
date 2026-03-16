dotnet tool install --global autosdk.cli --prerelease

autosdk init \
  HeyGen \
  HeyGenClient \
  https://raw.githubusercontent.com/tryAGI/HeyGen/main/heygen.yaml \
  tryAGI \
  --output .
