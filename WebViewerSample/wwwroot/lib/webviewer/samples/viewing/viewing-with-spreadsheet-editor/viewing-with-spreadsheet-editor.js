/* eslint-disable no-undef */
// @link WebViewerInstance: https://docs.apryse.com/api/web/WebViewerInstance.html
// @link UI.loadDocument: https://docs.apryse.com/api/web/UI.html#loadDocument__anchor

WebViewer.Iframe(
  {
    path: '../../../lib',
    initialDoc: 'https://pdftron.s3.amazonaws.com/downloads/pl/invoice_template.xlsx',
    enableFilePicker: true,
    initialMode: WebViewer.Modes.SPREADSHEET_EDITOR,
  },
  document.getElementById('viewer')
).then(instance => {
  window.instance = instance;
});
