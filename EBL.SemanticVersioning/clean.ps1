foreach ($folder in @("bin", "obj", "artifacts", "artifacts\obj")) {
  Get-ChildItem -Filter $folder -Directory -Recurse | Remove-Item -Recurse
}
