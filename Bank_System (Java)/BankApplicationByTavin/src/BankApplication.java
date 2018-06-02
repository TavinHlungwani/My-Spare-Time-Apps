/**
 * My Imports
 */
import java.awt.BorderLayout;
import java.awt.FlowLayout;
import java.awt.GridLayout;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.util.Date;
import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JOptionPane;
import javax.swing.JPanel;
import javax.swing.JTextField;

/**
 * @author TAVIN HLUNGWANI
 *
 */
public class BankApplication extends JFrame implements ActionListener{
	private static final long serialVersionUID = 1L;
	
	//GUI variables
	private JLabel lblAccount;
	private JLabel lblDeposit;
	private JLabel lblWithdraw;
	private JLabel lblBalance;
	private JLabel lblSummary;
	private JLabel lblClose;
	private JPanel pnlLbls;
	private JTextField txtAccount;
	private JTextField txtBalance;
	private JPanel pnlFields;
	private JButton btnDeposit;
	private JButton btnWithdraw;
	private JButton btnBalance;
	private JButton btnExit;
	private JLabel lblTransfer;
	private JButton btnTransfer;
	private JLabel lblAppName;
	private JPanel pnlAppName;
	
	/**
	 * non argument constructor to instantiate objects
	 */
	public BankApplication() {
		//Main panel
		JPanel panel = new JPanel();
		panel.setLayout(new BorderLayout());
		
		//labels and their panel
		lblAccount = new JLabel("Account Number");
		lblDeposit = new JLabel("Deposit");
		lblWithdraw = new JLabel("Withdraw");
		lblTransfer = new JLabel("Transfer");
		lblBalance = new JLabel("Balance");
		lblSummary  = new JLabel("Summary");
		lblClose = new JLabel("Close");
		pnlLbls = new JPanel();
		pnlLbls.add(lblAccount);
		pnlLbls.add(lblDeposit);
		pnlLbls.add(lblWithdraw);
		pnlLbls.add(lblTransfer);
		pnlLbls.add(lblBalance);
		pnlLbls.add(lblSummary);
		pnlLbls.add(lblClose);
		pnlLbls.setLayout(new GridLayout(0, 1));
		
		//Name of app label
		lblAppName = new JLabel("Bank Application");
		pnlAppName = new JPanel();
		pnlAppName.add(lblAppName);
		pnlAppName.setLayout(new FlowLayout());
		
		
		//fields and their panel
		pnlFields = new JPanel();
		pnlFields.setLayout(new GridLayout(0, 1));
		txtAccount = new JTextField();
		txtBalance = new JTextField();
		txtBalance.setText("Summary per transaction");
		txtBalance.setEditable(false);
		btnDeposit = new JButton("Deposit");
		btnWithdraw = new JButton("Withdraw");
		btnTransfer = new JButton("Transfer");
		btnBalance = new JButton("Balance");
		btnExit = new JButton("Exit");
		pnlFields.add(txtAccount);
		pnlFields.add(btnDeposit);
		pnlFields.add(btnWithdraw);
		pnlFields.add(btnTransfer);
		pnlFields.add(btnBalance);
		pnlFields.add(txtBalance);
		pnlFields.add(btnExit);
		
		
		//add listeners to buttons
		btnBalance.addActionListener(this);
		btnDeposit.addActionListener(this);
		btnWithdraw.addActionListener(this);
		btnTransfer.addActionListener(this);
		btnExit.addActionListener(this);

		
		//add panels to main panel
		panel.add(pnlAppName, BorderLayout.NORTH);
		panel.add(pnlFields, BorderLayout.CENTER);
		panel.add(pnlLbls, BorderLayout.WEST);
		
		
		//add main panel to frame or window
		add(panel);
	}
	
	/**
	 * The main point where program starts
	 * @param args
	 */
	public static void main(String[] args) {
		//instantiate frame or window
		BankApplication frame = new BankApplication();
		//set up the frame
		frame.setTitle("Tavin's Bank App");
		frame.setVisible(true);
		frame.setDefaultCloseOperation(EXIT_ON_CLOSE);
		frame.setPreferredSize(null);
		frame.setSize(650, 400);
		frame.setResizable(false);
	}
	
	//Global variables
	private String Acc = "";
	private static String Balance = "0.00";
	Double bal = Double.parseDouble(Balance);  
	
	//buttons to perform actions(Deposit, Withdraw,Transfer and Balance)
	//this method contains my functionalities
	@SuppressWarnings({ "deprecation"})
	@Override
	public void actionPerformed(ActionEvent btn) {
		Acc = txtAccount.getText();   //attain account number form text box
		//Deposit funds
		if(btn.getSource() == btnDeposit){
			String dep = JOptionPane.showInputDialog("Enter the ammount to deposit");  
			Double dep1 = Double.parseDouble(dep);  //convert
			bal = (bal + dep1);  //add deposit to balance
			JOptionPane.showMessageDialog(null, "R" + dep +" has been deposited.\nBalance is R" + bal, "DEPOSIT", JOptionPane.INFORMATION_MESSAGE);
			//to be used under summary
			txtBalance.setText("R"+ dep +" deposited and New Balance is R" + bal);
		}
		
		//withdraw funds
		if(btn.getSource() == btnWithdraw){
			//attain input
			String draw = JOptionPane.showInputDialog("How much do you want to withdraw?");
			Double dr = Double.parseDouble(draw);   //convert
			while(dr > bal){    //input handling
				JOptionPane.showMessageDialog(null, "Insufficient funds", "INSUFFICIENT FUNDS", JOptionPane.WARNING_MESSAGE);   //alert
				draw = JOptionPane.showInputDialog("Enter ammount less than your Balance");   //get input
				dr = Double.parseDouble(draw);	
			}
			//subtract draw from balance
			bal = (bal - dr);
			//notify
			JOptionPane.showMessageDialog(null, "Ammount of R" + dr +" has been withdrawn \nBalance R"+bal,"WITHDRAW", JOptionPane.INFORMATION_MESSAGE);
			
			//to be used under summary
			txtBalance.setText("R" + dr + " withdrawn and New Balance is R" + bal);
		}
		
		//transfer
		if(btn.getSource() == btnTransfer){
			//get input from user
			String rcp = JOptionPane.showInputDialog("Enter name of a person you wish to transfer funds to");
			String tr = JOptionPane.showInputDialog("How much do you want to transfer to " + rcp);
			Double tr1 = Double.parseDouble(tr);  //convert 
			while(tr1 > bal){     //input handling
				tr = JOptionPane.showInputDialog("You have R" + bal +" in your account,\nTry another ammount");
				tr1 = Double.parseDouble(tr);   //convert again
			}
			//send money to recipient
			bal = (bal - tr1);
			//notify
			JOptionPane.showMessageDialog(null, "You transferred R"+ tr1 +" to " + rcp +"\nBalance R" + bal,"TRANSFER", JOptionPane.INFORMATION_MESSAGE);
			
			//to be used under summary
			txtBalance.setText("R"+ tr1+" transferred to " + rcp + " and New Balance is R" + bal);
		}

		//Check Balance
		if(btn.getSource() == btnBalance){
			//write on text box
			txtBalance.setText("Balance after all Transactions is: R" + bal + " .On account number: "+ Acc );
		}
		
		//Terminate application
		if(btn.getSource() == btnExit){
			Date day = new Date(); 		day.getDay();  //attain date
			JOptionPane.showMessageDialog(null, "All transactions perfomed on " + day, "DATE", JOptionPane.INFORMATION_MESSAGE);    //date of use
			JOptionPane.showMessageDialog(null, "Thanks for using my application, \n                    GoodBye!", "CLOSING...", JOptionPane.WARNING_MESSAGE);  //notify user
			System.exit(0);			//close system
		}
	}
}
