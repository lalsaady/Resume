document.addEventListener('DOMContentLoaded', () => {
  const input = document.getElementById('cmdInput');
  const output = document.getElementById('output');

  // Append the cmd input line
  function appendLine(text) {
    const div = document.createElement('div');
    div.className = 'highlight';
    div.innerHTML= text;
    output.appendChild(div);
    window.scrollTo(0, document.body.scrollHeight);
  }

  // Append block output
  function appendBlock(text) {
    const div = document.createElement('div');
    div.className = 'line';
    div.innerHTML = text;
    output.appendChild(div);
    window.scrollTo(0, document.body.scrollHeight);
  }

  // Define allowed commands
  const allowedCommands = ["help", "about", "education", "languages", "tools", "experience", "projects", "contact", "clear"];
  
  // Runs the command
  async function runCommand(cmd) {
    const outputDiv = document.getElementById("output"); 
    appendLine(`guest@resume:~$ ${cmd}`);

    if (!allowedCommands.includes(cmd)) {
      appendLine("Invalid command, type 'help' to see available commands.");
      return;
    }

    try {
      const res = await fetch(`/run?cmd=${encodeURIComponent(cmd)}`);
      const data = await res.json();

      // Clear the terminal but keep the welcome line
      if (data.clear) {
        const welcomeLine = outputDiv.firstElementChild;
        outputDiv.innerHTML = "";
        outputDiv.appendChild(welcomeLine);
        return;
      }

      // Append the data if provided
      if (data.output !== undefined) {
        appendBlock(data.output);
      }

    } catch (e) {
      // Handle errors gracefully
      appendLine('Error contacting server.');
    }
  }

  // Listen for the enter key to run the command
  input.addEventListener('keydown', (e) => {
    if (e.key === 'Enter') {
      const cmd = input.value.trim();
      input.value= '';
      if (cmd.length) runCommand(cmd);
      e.preventDefault();
    }
  });
});
