let clickOutsideListener = null;

function setupClickOutsideListener(elementId, dotNetObject) {
    if (clickOutsideListener) {
        // Remove the existing listener if it was already added
        document.removeEventListener('click', clickOutsideListener);
    }

    clickOutsideListener = function (event) {
        const element = document.getElementById(elementId);
        if (element && !element.contains(event.target)) {
            // Call the .NET method to hide the dropdown
            dotNetObject.invokeMethodAsync('HideDropdown');
        }
    };

    // Add the event listener to detect clicks outside
    document.addEventListener('click', clickOutsideListener);
}
function positionDropdownUnderUserImg() {
    console.log("Correct JsInterop call");
    let userImg = document.getElementById("userImg");
    let dropdown = document.getElementById("dropdown");

    if (userImg && dropdown) {
        let rect = userImg.getBoundingClientRect();
        dropdown.style.position = "absolute";
        dropdown.style.top = `${rect.bottom + window.scrollY}px`;
        let offsetLeft = -100; // Adjust this value to move more to the left
        dropdown.style.left = `${rect.left + window.scrollX + offsetLeft}px`;
        dropdown.style.display = "block";
    }
}
