function UploadFile () {
    
    uploadFile = (event) => {
        event.preventDefault();

    }
   
        return <button onClick={this.uploadFile}>Upload file</button>;
   
}
ReactDOM.render(
    <UploadFile />,
    document.getElementById("content")
);