set -e
dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl --fail --silent --show-error -o openapi.yaml https://raw.githubusercontent.com/tryAGI/HeyGen/main/heygen.yaml
autosdk generate openapi.yaml \
  --namespace HeyGen \
  --clientClassName HeyGenClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations
